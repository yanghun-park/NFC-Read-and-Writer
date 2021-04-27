# NFC-Read-and-Writer
NFC Communication Programs Implemented in C# (Unity Available)


## Introduce
> This program allows you to read and write NFC tags in a Windows 10 environment. <br/>
> We checked the normal operation in the Unity environment. <br/>


## Environment
- Windows 10
- Visual Studio 2019
- .NET Core 3.1


## How to use
> ## Option Guide
> 1. Authentication<br/>
>
> > Chceked : If block access requires authentication (ex. Mifare S50)<br/>Non-Checked : Access to blocks does not require authentication (ex. Mifare Ultralight)<br/>
> 2. Protect Block<br/>
>
> > Checked : Prevent writing to important blocks.  (0, 3, 4, 7, 8, 11, 12...)
> >
> > Non-Checked : Turn off block blocking. 
>
> ## First, create an object as shown below. <br/>
>    NFCReader NFC = NFC Reader(Device Number); <br/>
> > Device number is INT type <br/>
> ## Second, When obtaining card UID information or reading data, create the following object <br/>
>     NFCReader.CardData card = new NFCReader.CardData();
> ## 1. Read NFC Card UID
>     card = NFC.readCardUID();
>     string result = card.cardResult;
>     string deviceInfo = card.readerName;  // Get Device Info
> ## 2. Read NFC Data
>     card = NFC.readCardData(Block, auth);
>     string result = card.cardResult;
> > Block is INT type <br/>
> >
> > auth is BOOL type <br/>
> ## 3. Write NFC Data
>     bool result = NFC.writeCardData(Block, Value, auth);
> > Block is INT Type <br/>
> > Value is string Type <br/>
> >
> > auth is BOOL type <br/>


## Running Program
![overview](/NFC_overview.png) <br/>

<br/>Thank you!