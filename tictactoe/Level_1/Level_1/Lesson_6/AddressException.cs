using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_6
{
    public enum ErrorCodes
    {
        NoAddress,
        NoBuilding,
    }

    [Serializable]
    class AddressException : Exception
    {
        public ErrorCodes Code { get; }

        public AddressException(ErrorCodes code)
        {
            Code = code;
        }
    }
}
