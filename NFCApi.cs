using System;
using System.Runtime.InteropServices;

namespace SmardCard
{
    class NFCApi
    {
        [DllImport("winscard.dll")]
        public static extern uint SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, out IntPtr phContext);

        [DllImport("winscard.dll", EntryPoint = "SCardListReadersW", CharSet = CharSet.Unicode)]
        public static extern uint SCardListReaders(
          IntPtr hContext, byte[] mszGroups, byte[] mszReaders, ref UInt32 pcchReaders);

        [DllImport("winscard.dll")]
        public static extern uint SCardReleaseContext(IntPtr phContext);

        [DllImport("winscard.dll", EntryPoint = "SCardConnectW", CharSet = CharSet.Unicode)]
        public static extern uint SCardConnect(IntPtr hContext, string szReader,
             uint dwShareMode, uint dwPreferredProtocols, ref IntPtr phCard,
             ref IntPtr pdwActiveProtocol);

        [DllImport("winscard.dll")]
        public static extern uint SCardDisconnect(IntPtr hCard, int Disposition);

        [StructLayout(LayoutKind.Sequential)]
        internal class SCARD_IO_REQUEST
        {
            internal int dwProtocol;
            internal int cbPciLength;
            public SCARD_IO_REQUEST()
            {
                dwProtocol = 0;
            }
        }

        [DllImport("winscard.dll")]
        public static extern uint SCardTransmit(IntPtr hCard, IntPtr pioSendRequest, byte[] SendBuff, int SendBuffLen, SCARD_IO_REQUEST pioRecvRequest,
                byte[] RecvBuff, ref int RecvBuffLen);

        [DllImport("winscard.dll")]
        public static extern uint SCardControl(IntPtr hCard, int controlCode, byte[] inBuffer, int inBufferLen, byte[] outBuffer, int outBufferLen, ref int bytesReturned);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SCARD_READERSTATE
        {
            internal string szReader;
            internal IntPtr pvUserData;
            internal UInt32 dwCurrentState;
            internal UInt32 dwEventState;
            internal UInt32 cbAtr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            internal byte[] rgbAtr;
        }

        [DllImport("winscard.dll", EntryPoint = "SCardGetStatusChangeW", CharSet = CharSet.Unicode)]
        public static extern uint SCardGetStatusChange(IntPtr hContext, int dwTimeout, [In, Out] SCARD_READERSTATE[] rgReaderStates, int cReaders);

        [DllImport("winscard.dll")]
        public static extern int SCardStatus(IntPtr hCard, string szReader, ref int cch, ref int state, ref IntPtr protocol, byte[] bAttr, ref int cByte);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern void FreeLibrary(IntPtr handle);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr handle, string procName);
    }
}
