using System.Threading.Tasks;
using NetCoreOneSignalV7Client.Models;

namespace NetCoreOneSignalV7Client
{
    public interface IOneSignalClient
    {
        Task<OneSignalNotificationResponse> NotifySpecificDevicesAsync(NotificationModel notificationModel);
    }
}