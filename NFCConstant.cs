using System;

namespace SmardCard
{
    class NFCcard
    {
        public const uint SCARD_S_SUCCESS = 0;
        public const uint SCARD_E_NO_SERVICE = 0x8010001D;
        public const uint SCARD_E_TIMEOUT = 0x8010000A;

        public const uint SCARD_SCOPE_USER = 0;
        public const uint SCARD_SCOPE_TERMINAL = 1;
        public const uint SCARD_SCOPE_SYSTEM = 2;

        public const int SCARD_STATE_UNAWARE = 0x0000;
        public const int SCARD_STATE_CHANGED = 0x00000002;
        public const int SCARD_STATE_PRESENT = 0x00000020;
        public const UInt32 SCARD_STATE_EMPTY = 0x00000010;
        public const int SCARD_SHARE_SHARED = 0x00000002;
        public const int SCARD_SHARE_EXCLUSIVE = 0x00000001;
        public const int SCARD_SHARE_DIRECT = 0x00000003;

        public const int SCARD_PROTOCOL_T0 = 1;
        public const int SCARD_PROTOCOL_T1 = 2;
        public const int SCARD_PROTOCOL_RAW = 4;

        public const int SCARD_LEAVE_CARD = 0;
        public const int SCARD_RESET_CARD = 1;
        public const int SCARD_UNPOWER_CARD = 2;
        public const int SCARD_EJECT_CARD = 3;

        // SCardStatus status values
        public const int SCARD_UNKNOWN = 0x00000000;
        public const int SCARD_ABSENT = 0x00000001;
        public const int SCARD_PRESENT = 0x00000002;
        public const int SCARD_SWALLOWED = 0x00000003;
        public const int SCARD_POWERED = 0x00000004;
        public const int SCARD_NEGOTIABLE = 0x00000005;
        public const int SCARD_SPECIFICMODE = 0x00000006;
    }
}