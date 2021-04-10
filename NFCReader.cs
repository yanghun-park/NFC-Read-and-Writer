using System;
using SmardCard;
using System.Text;

// NFC Project (2021-04-09)
// Version : 1.00v

public class NFCReader
{
    private IntPtr hContext = IntPtr.Zero;
    private IntPtr hCard;
    private IntPtr activeProtocol;
    private int deviceNum;

    public string readerName;
    public string CardResult;
    public bool ThrowExceptionLog;

    const int bufferSize = 256;
    public byte[] recvBuffer = new byte[bufferSize]; // Buffer size for receiving
    private int sendLen;
    private int recvLen;

    private enum transType
    {
        auth, cardID, cardRead, cardWrite
    }

    public NFCReader(int Num)
    {
        this.deviceNum = Num;
    }

    public class CardData
    {
        public string readerName = "";
        public string cardResult = "";
    }

    public CardData readCardData(int block)
    {
        // sendBuffer -> APDU {Class, INS, P1, P2, Le}
        byte[] sendBuffer = new byte[] {0xff, 0xb0, 0x00, (byte)block, 0x10}; // Data Acquisition APDU
        bool authCheck = false;
        int ret;

        try // Attempt to authenticate
        {
            SCardEstablishContext();
            SCardListReaders();
            SCardConnect();
            SCardStatus();
            authCheck = AuthProcess(block);
        }
        catch (Exception e)
        {
            if (ThrowExceptionLog)
                //Debug.LogWarning(e);

            return new CardData();
        }

        if (authCheck) // If the certification is successful
        {
            ret = SCardTransmit(sendBuffer, transType.cardRead);
            
            if (ret == -200)
                return new CardData { readerName = readerName, cardResult = "Error" };
            if (ret == -202)
                return new CardData { readerName = readerName, cardResult = "Error" };
            if (ret != NFCcard.SCARD_S_SUCCESS)
                return new CardData { readerName = readerName, cardResult = "Error" };

            SCardDisconnect();
            return new CardData { readerName = readerName, cardResult = CardResult };
        }
        SCardDisconnect();
        return new CardData { readerName = readerName, cardResult = "Error" };
    }

    public bool writeCardData(int block, string value)
    {
        // sendBuffer -> APDU {Class, INS, P1, P2, Le}
        byte[] sendBuffer = new byte[256];
        sendBuffer[0] = 0xff; // Data recordingdd
        sendBuffer[1] = 0xd6;
        sendBuffer[2] = 0x00;
        sendBuffer[3] = (byte)block;
        sendBuffer[4] = 0x10;
        
        char[] byteValue = value.ToCharArray();
        bool authCheck = false;
        int ret;

        try // Attempt to authenticate
        {
            SCardEstablishContext();
            SCardListReaders();
            SCardConnect();
            SCardStatus();
            authCheck = AuthProcess(block);
        }
        catch (Exception e)
        {
            if (ThrowExceptionLog)
                
                //Debug.LogWarning(e);

            return false;
        }

        if (authCheck) // If the certification is successful
        {
            for (int i = 0; i < value.Length; i++) // Add string converted to byte array after sendBuffer
                sendBuffer[i + 5] = (byte)byteValue[i];

            sendLen = sendBuffer[4] + 5;
            recvLen = 0x02;

            ret = SCardTransmit(sendBuffer, transType.cardWrite);

            if (ret != NFCcard.SCARD_S_SUCCESS)
                return false;
            else
                return true;
        }
        else
            return false;
    }


    public CardData readCardUID()
    {
        // sendBuffer -> APDU {Class, INS, P1, P2, Le}
        byte[] sendBuffer = new byte[] { 0xff, 0xca, 0x00, 0x00, 0x00 };  // get Card UID

        try
        {
            SCardEstablishContext();
            SCardListReaders();
            SCardConnect();
            SCardStatus();
            SCardTransmit(sendBuffer, transType.cardID);
            SCardDisconnect();
        }
        catch (Exception e)
        {
            if (ThrowExceptionLog)
                //Debug.LogWarning(e);

            return new CardData();
        }
        return new CardData { readerName = readerName, cardResult = CardResult };
    }

    public string GetCardReaderName()
    {
        try
        {
            SCardEstablishContext();
            SCardListReaders();
        }
        catch (Exception e)
        {
            if (ThrowExceptionLog)
                //Debug.LogWarning(e);

            return "";
        }
        return readerName;
    }

    private uint SCardEstablishContext()
    {
        uint ret = NFCApi.SCardEstablishContext(NFCcard.SCARD_SCOPE_USER, IntPtr.Zero, IntPtr.Zero, out hContext);
        if (ret != NFCcard.SCARD_S_SUCCESS)
        {
            string message;
            switch (ret)
            {
                case NFCcard.SCARD_E_NO_SERVICE:
                    message = "Service is not ready.";
                    break;
                default:
                    message = "Unable to contact service. code = " + ret;
                    break;
            }
            throw new ApplicationException(message);
        }

        if (hContext == IntPtr.Zero)
        {
            throw new ApplicationException("Failed to acquire context. ");
        }
        return ret;
    }

    private void SCardListReaders()
    {
        uint pcchReaders = 0;

        // Get string buffer size for NFC reader
        uint ret = NFCApi.SCardListReaders(hContext, null, null, ref pcchReaders);
        if (ret != NFCcard.SCARD_S_SUCCESS)
        {
            // If the detection fails
            throw new ApplicationException("NFC Reader not found. ");
        }

        // Import NFC Reader String
        byte[] mszReaders = new byte[bufferSize]; // Assign Array by String+1
        ret = NFCApi.SCardListReaders(hContext, null, mszReaders, ref pcchReaders);
        if (ret != NFCcard.SCARD_S_SUCCESS)
        {
            // If the detection fails
            throw new ApplicationException("Failed to acquire NFC Reader. ");
        }


        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        string readerNameMultiString = unicodeEncoding.GetString(mszReaders);

        // Recognized NFC Reader
        string[] readerDevice = readerNameMultiString.Split('\0');
        readerName = readerDevice[deviceNum];
    }

    private void SCardConnect()
    {
        activeProtocol = IntPtr.Zero;
        hCard = IntPtr.Zero;
        uint ret = NFCApi.SCardConnect(hContext, readerName, NFCcard.SCARD_SHARE_SHARED, NFCcard.SCARD_PROTOCOL_T1, ref hCard, ref activeProtocol);
        if (ret != NFCcard.SCARD_S_SUCCESS)
            throw new ApplicationException("Unable to access card. code = " + ret);
    }

    private void SCardStatus()
    {
        int dwReaderLen = readerName.Length;
        int dwState = 0;
        byte[] atr = new byte[64]; // ATR
        int dwAtrLen = atr.Length;
        long lResult = NFCApi.SCardStatus(hCard, null, ref dwReaderLen, ref dwState, ref activeProtocol, atr, ref dwAtrLen);
        if (lResult != NFCcard.SCARD_S_SUCCESS)
            throw new ApplicationException("ATR acquisition failed. ");
    }

    private bool AuthProcess(int block)
    {
        // authBuffer -> APDU {Class, INS, P1, P2, Lc, CommandData, Le1, Le2, Le3}
        byte[] authBuffer = new byte[] { 0xff, 0x86, 0x00, 0x00, 0x05, 0x00, 0x00, (byte)block, 0x60, 0x00 }; // 인증 APDU
        sendLen = 0x05;
        recvLen = 0x10;
        int ret = 0;

        try
        {
            clearBuffer();
            ret = SCardTransmit(authBuffer, transType.auth);
        }
        catch (Exception e)
        {
            if (ThrowExceptionLog)
                //Debug.LogWarning(e);

            return false;
        }

        if (ret != NFCcard.SCARD_S_SUCCESS) // If the certification is not successful
            return false;

        return true;
    }

    private int SCardTransmit(byte[] sendBuffer, transType type)
    {
        NFCApi.SCARD_IO_REQUEST ioRecv = new NFCApi.SCARD_IO_REQUEST();
        ioRecv.cbPciLength = 255;
        string tmpStr = "";

        recvLen = recvBuffer.Length;
        sendLen = sendBuffer.Length;

        IntPtr handle = NFCApi.LoadLibrary("Winscard.dll");
        IntPtr pci = NFCApi.GetProcAddress(handle, "g_rgSCardT1Pci");
        NFCApi.FreeLibrary(handle);

        tmpStr = "";

        uint ret = NFCApi.SCardTransmit(hCard, pci, sendBuffer, sendLen, ioRecv, recvBuffer, ref recvLen);
        if (ret != NFCcard.SCARD_S_SUCCESS)
            throw new ApplicationException("NFC 카드와 송신에 실패하였습니다. code = " + ret);

        try
        {
            switch (type)
            {
                case transType.auth: // Authenticate
                    for (int i = (recvLen - 2); i <= (recvLen - 1); i++)
                        tmpStr = tmpStr + string.Format("{0:X2}", recvBuffer[i]);
                    if (tmpStr.Trim() != "9000") // 반환 바이트를 사용할 수 없을때
                        return -202;
                    break;

                case transType.cardID: // If the card is UID
                    CardResult = BitConverter.ToString(recvBuffer, 0, recvLen - 2); // 수신 데이터
                    break;

                case transType.cardRead: // Read card data
                    CardResult = Encoding.Default.GetString(recvBuffer, 0, recvLen); // 수신 데이터
                    break;

                case transType.cardWrite: // Writing card data
                    break; // nothing
            }
            return (int)ret;
        }
        catch (IndexOutOfRangeException)
        {
            return -200;
        }
    }

    private void SCardDisconnect()
    {
        uint ret = NFCApi.SCardDisconnect(hCard, NFCcard.SCARD_LEAVE_CARD);

        if (ret != NFCcard.SCARD_S_SUCCESS)
            throw new ApplicationException("Failed to disconnect NFC card. code = " + ret);
    }

    private void clearBuffer()
    {
        for (int i = 0; i < 256; i++)
            recvBuffer[i] = 0;
    }
}
