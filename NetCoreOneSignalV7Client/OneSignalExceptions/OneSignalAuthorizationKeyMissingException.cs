using System;

namespace NetCoreOneSignalV7Client.OneSignalExceptions
{
    public class OneSignalAuthorizationKeyMissingException : Exception
    {
        public OneSignalAuthorizationKeyMissingException()
        {
        }

        public OneSignalAuthorizationKeyMissingException(string message) : base(message)
        {
        }
    }
}