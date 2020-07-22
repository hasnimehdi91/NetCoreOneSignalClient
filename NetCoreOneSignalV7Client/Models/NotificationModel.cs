using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreOneSignalV7Client.Models
{
    public class NotificationModel
    {
        [JsonProperty("include_player_ids")]
        public IEnumerable<string> Players { get; set; }

        [JsonProperty("include_external_user_ids")]
        public IEnumerable<string> ExternalUsers { get; set; }

        [JsonProperty("include_email_tokens")]
        public IEnumerable<string> EmailTokens { get; set; }

        [JsonProperty("include_ios_tokens")]
        public IEnumerable<string> IosTokens { get; set; }

        [JsonProperty("include_wp_wns_uris")]
        public IEnumerable<string> WpWnsUris { get; set; }

        [JsonProperty("include_amazon_reg_ids")]
        public IEnumerable<string> AmazonIds { get; set; }

        [JsonProperty("include_chrome_reg_ids")]
        public IEnumerable<string> ChromeIds { get; set; }

        [JsonProperty("include_chrome_web_reg_ids")]
        public IEnumerable<string> ChromeWebIds { get; set; }

        [JsonProperty("include_android_reg_ids")]
        public IEnumerable<string> AndroidIds { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("contents")]
        public object Contents { get; set; }

        [JsonProperty("headings")]
        public object Headings { get; set; }
        
        [JsonProperty("subtitle")]
        public object SubTitle { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("content_available")]
        public bool? ContentAvailable { get; set; }

        [JsonProperty("email_subject")]
        public string EmailSubject { get; set; }

        [JsonProperty("email_body")]
        public string EmailBody { get; set; }

        [JsonProperty("email_from_name")]
        public string EmailFromName { get; set; }

        [JsonProperty("email_from_address")]
        public string EmailFromAdd { get; set; }

        [JsonProperty("mutable_content")]
        public bool? MutableContent { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("huawei_msg_type")]
        public string HuaweiMessageType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("app_url")]
        public string AppUrl { get; set; }

        [JsonProperty("ios_attachments")]
        public object IosAttachments { get; set; }

        [JsonProperty("big_picture")]
        public string BigPicture { get; set; }

        [JsonProperty("chrome_web_image")]
        public string ChromeWebImage { get; set; }

        [JsonProperty("adm_big_picture")]
        public string AmazonBigPicture { get; set; }

        [JsonProperty("chrome_big_picture")]
        public string ChromeBigPicture { get; set; }

        [JsonProperty("buttons")]
        public IEnumerable<object> Buttons { get; set; }

        [JsonProperty("web_buttons")]
        public IEnumerable<object> WebButtons { get; set; }

        [JsonProperty("ios_category")]
        public string IosCategory { get; set; }
        
        [JsonProperty("android_channel_id")]
        public string AndroidChannelId { get; set; }

        [JsonProperty("huawei_channel_id")]
        public string HuaweiChannelId { get; set; }

        [JsonProperty("existing_android_channel_id")]
        public string ExistingAndroidChannelId { get; set; }
        
        [JsonProperty("huawei_existing_channel_id")]
        public string ExistingHuaweiChannelId { get; set; }

        [JsonProperty("android_background_layout")]
        public object AndroidBackgroundLayout { get; set; }

        [JsonProperty("small_icon")]
        public string SmallIcon { get; set; }

        [JsonProperty("huawei_small_icon")]
        public string HuaweiSmallIcon { get; set; }

        [JsonProperty("large_icon")]
        public string LargeIcon { get; set; }

        [JsonProperty("huawei_large_icon")]
        public string HuaweiLargeIcon { get; set; }

        [JsonProperty("adm_small_icon")]
        public string AmazonSmallIcon { get; set; }

        [JsonProperty("adm_large_icon")]
        public string AmazonLargeIcon { get; set; }

        [JsonProperty("chrome_web_icon")]
        public string ChromeWebIcon { get; set; }

        [JsonProperty("chrome_web_badge")]
        public string ChromeWebBadge { get; set; }

        [JsonProperty("firefox_icon")]
        public string FirefoxIcon { get; set; }

        [JsonProperty("chrome_icon")]
        public string ChromeIcon { get; set; }

        [JsonProperty("ios_sound")]
        public string IosSound { get; set; }

        [JsonProperty("android_sound")]
        public string AndroidSound { get; set; }

        [JsonProperty("huawei_sound")]
        public string HuaweiSound { get; set; }

        [JsonProperty("adm_sound")]
        public string AmazonSound { get; set; }

        [JsonProperty("wp_wns_sound")]
        public string WindowsSound { get; set; }

        [JsonProperty("android_led_color")]
        public string AndroidLetColor { get; set; }

        [JsonProperty("huawei_led_color")]
        public string HuaweiLedColor { get; set; }

        [JsonProperty("android_accent_color")]
        public string AndroidAccentColor { get; set; }

        [JsonProperty("huawei_accent_color")]
        public string HuaweiAccentColor { get; set; }

        [JsonProperty("android_visibility")]
        public int? AndroidVisibility { get; set; }

        [JsonProperty("ios_badgeType")]
        public string IosBadgeType { get; set; }

        [JsonProperty("ios_badgeCount")]
        public int? IosBadgeCount { get; set; }

        [JsonProperty("collapse_id")]
        public string CollapseId { get; set; }

        [JsonProperty("apns_alert")]
        public object ApnsAlert { get; set; }

        [JsonProperty("send_after")]
        public string SendAfter { get; set; }

        [JsonProperty("delayed_option")]
        public string DelayedOption { get; set; }

        [JsonProperty("delivery_time_of_day")]
        public string DeliveryTimeOfDay { get; set; }

        [JsonProperty("ttl")]
        public int? TimeToLive { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("apns_push_type_override")]
        public string ApnsPushTypeOverride { get; set; }

        [JsonProperty("android_group")]
        public string AndroidGroup { get; set; }

        [JsonProperty("android_group_message")]
        public object AndroidGroupMessage { get; set; }

        [JsonProperty("adm_group")]
        public string AmazonGroup { get; set; }

        [JsonProperty("adm_group_message")]
        public string AmazonGroupMessage { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("summary_arg")]
        public string SummaryTag { get; set; }

        [JsonProperty("summary_arg_count")]
        public int? SummaryArgCount { get; set; }

        [JsonProperty("isIos")]
        public bool? IsIos { get; set; }

        [JsonProperty("isAndroid")]
        public bool? IsAndroid { get; set; }

        [JsonProperty("isHuawei")]
        public bool? IsHuawei { get; set; }

        [JsonProperty("isAnyWeb")]
        public bool? IsAnyWeb { get; set; }

        [JsonProperty("isEmail")]
        public bool? IsEmail { get; set; }

        [JsonProperty("isChromeWeb")]
        public bool? IsChromeWeb { get; set; }

        [JsonProperty("isFirefox")]
        public bool? IsFireFox { get; set; }

        [JsonProperty("isSafari")]
        public bool? IsSafari { get; set; }

        [JsonProperty("isWP_WNS")]
        public bool? IsWindows { get; set; }

        [JsonProperty("isAdm")]
        public bool? IsAmazon { get; set; }

        [JsonProperty("isChrome")]
        public bool? IsChrome { get; set; }

        [JsonProperty("channel_for_external_user_ids")]
        public string ChannelForExternalUserIds { get; set; }
    }
}