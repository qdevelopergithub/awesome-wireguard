using Com.Wireguard.Android;
using Com.Wireguard.Config;
using Com.Wireguard.Crypto;
using Com.Wireguard.Util;

namespace WireguardVPN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
