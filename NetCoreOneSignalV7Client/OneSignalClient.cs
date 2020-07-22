using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NetCoreOneSignalV7Client.Models;
using NetCoreOneSignalV7Client.OneSignalExceptions;
using Newtonsoft.Json;

namespace NetCoreOneSignalV7Client
{
    public class OneSignalClient : IOneSignalClient
    {
        private readonly OneSignalOptions _options;

        private const string Url = "https://onesignal.com/api/v1/notifications";

        private HttpClient Client => GetClient();

        public OneSignalClient(OneSignalOptions options)
        {
            _options = options;

            if (string.IsNullOrWhiteSpace(_options.AppId))
            {
                throw new OneSignalAppIdMissingException("AppId is missing");
            }

            if (string.IsNullOrWhiteSpace(_options.AuthorizationKey))
            {
                throw new OneSignalAuthorizationKeyMissingException("AuthorizationKey is missing");
            }

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }

        public async Task<OneSignalNotificationResponse> NotifySpecificDevicesAsync(NotificationModel notificationModel)
        {
            using (Client)
            {
                notificationModel.AppId = _options.AppId;
                var response = await Client.PostAsync(Url, GetBody(notificationModel));

                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new OneSignalResponseException(content);
                }

                try
                {
                    var responseObject = JsonConvert.DeserializeObject<OneSignalNotificationResponse>(content);
                    return responseObject;
                }
                catch (Exception)
                {
                    throw new OneSignalResponseException(content);
                }
            }
        }

        private HttpClient GetClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {_options.AuthorizationKey}");
            return client;
        }

        private static StringContent GetBody(object o)
            => new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8, "application/json");
    }
}