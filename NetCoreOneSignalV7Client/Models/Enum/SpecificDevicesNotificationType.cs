using System.Runtime.Serialization;

namespace NetCoreOneSignalV7Client.Models.Enum
{
    public enum SpecificDevicesNotificationType
    {
        [EnumMember(Value = "Players")]
        Players = 0,
        
        [EnumMember(Value = "ExternalUsers")]
        ExternalUsers = 1,
        
        [EnumMember(Value = "EmailTokens")]
        EmailTokens = 2,
        
        [EnumMember(Value = "IosTokens")]
        IosTokens = 3,
        
        [EnumMember(Value = "WpWnsUris")]
        WpWnsUris = 4,
        
        [EnumMember(Value = "AmazonIds")]
        AmazonIds = 5,
        
        [EnumMember(Value = "ChromeIds")]
        ChromeIds = 6,
        
        [EnumMember(Value = "ChromeWebIds")]
        ChromeWebIds = 7,
        
        [EnumMember(Value = "AndroidIds")]
        AndroidIds = 8,
        
        [EnumMember(Value = "Segment")]
        Segment = 9
    }
}