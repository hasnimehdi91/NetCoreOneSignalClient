using System;

namespace NetCoreOneSignalV7Client.OneSignalExceptions
{
    public class OneSignalAppIdMissingException : Exception
    {
        public OneSignalAppIdMissingException()
        {
        }

        public OneSignalAppIdMissingException(string message) : base(message)
        {
        }
    }
}