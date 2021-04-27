# NFC-Read-and-Writer
NFC 통신 프로그램을 C#으로 구현하였습니다.  (Unity 사용 가능)


## 프로그램 소개
> 이 프로그램은 윈도우10 환경에서 NFC 태그를 읽고 쓸 수 있도록 해줍니다. <br/>
> 유니티 환경에서 정상 동작하는것을 확인했습니다. <br/>


## 실행 환경
- Windows 10
- Visual Studio 2019
- .NET Core 3.1


## 사용법
> ## 옵션 가이드
> 1. Authentication<br/>
>
> > 체크할 경우 : 인증 블록에 접근 (ex. Mifare S50)<br/>체크하지 않을 경우 : 인증 블록에 접근하지 않음 (ex. Mifare Ultralight)<br/>
> 2. Protect Block<br/>
>
> > 체크할 경우 : 중요한 블럭 보호  (0, 3, 4, 7, 8, 11, 12...)
> >
> > 체크하지 않을 경우 : 보호하지 않음 
>
> ## 첫번째, 아래와 같은 객체를 생성. <br/>
>    NFCReader NFC = NFC Reader(Device Number); <br/>
> > Device number는 INT 타입 <br/>
> ## 두번째, 카드 UID 정보 및 데이터를 담을 객체 생성. <br/>
>     NFCReader.CardData card = new NFCReader.CardData();
> ## 1. NFC Card UID 정보 읽기
>     card = NFC.readCardUID();
>     string result = card.cardResult;
>     string deviceInfo = card.readerName;  // Get Device Info
> ## 2. NFC 데이터 읽기
>     card = NFC.readCardData(Block, auth);
>     string result = card.cardResult;
> > Block은 INT 타입 <br/>
> >
> > auth은 BOOL 타입 <br/>
> ## 3. NFC 데이터 쓰기
>     bool result = NFC.writeCardData(Block, Value, auth);
> > Block은 INT 타입 <br/>
> > Value는 string 타입 <br/>
> >
> > auth은 BOOL 타입 <br/>


## 구동중인 모습
![overview](/NFC_overview.png) <br/>

<br/>

감사합니다. 

