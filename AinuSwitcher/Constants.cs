
namespace AinuSwitcher
{
    public class Constants
    {
        // Use this address if we cannot grab from ips.txt
        public const string AinuHardcodedIp = "18.220.131.50";

        // Grab address from here when possible
        public const string AinuIpApiAddress = "https://shibui.pw/static/ips.txt";

        public const string UiInstallCertificate = "Verify Certificate";

        public const string UiUninstallCertificate = "Unverify Certificate";

        public const string UiYouArePlayingOnAinu = "Connected to osu! shibui";

        public const string UiYouArePlayingOnOfficial = "Connected to Bancho";

        public const string UiSwitchToAinu = "Switch to osu!shibui";

        public const string UiSwitchToOfficial = "Switch to Bancho";

        public const string UiUpdatingStatus = "Loading...";
    }
}
