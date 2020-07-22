namespace NetCoreOneSignalV7Client
{
    public class OneSignalOptions
    {
        /// <summary>
        /// Application UUID
        /// Public Key used for initialization and app identification.
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// API authorization key
        /// Private key used for most API calls involved with sending push notifications and updating users.
        /// </summary>
        public string AuthorizationKey { get; set; }
    }
}