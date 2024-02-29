using WebHMI.Debugging;

namespace WebHMI
{
    public class WebHMIConsts
    {
        public const string LocalizationSourceName = "WebHMI";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d79a5760152a47948b075d91647a839a";
    }
}


