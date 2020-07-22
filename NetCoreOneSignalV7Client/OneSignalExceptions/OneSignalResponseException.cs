using System;

namespace NetCoreOneSignalV7Client.OneSignalExceptions
{
    public class OneSignalResponseException : Exception
    {
        public OneSignalResponseException()
        {
        }

        public OneSignalResponseException(string message) : base(message)
        {
        }
    }
}