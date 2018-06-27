using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Views;
using AtlantisApplication.Views.Login;
using Xamarin.Forms;

namespace AtlantisApplication
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void SensorsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListSensorsView());
        }

        private void CommandsButtonClicked(object sender, EventArgs e)
        {

        }

        private void UsersButtonClicked(object sender, EventArgs e)
        {

        }

        private void MetricsButtonClicked(object sender, EventArgs e)
        {

        }

        private void CheckInternetButtonClicked(object sender, EventArgs e)
        {
            // bool internetActive = DependencyService.Get<IDeviceState>().isNetworkReachable();
            // this.DisplayAlert("Device Network", internetActive.ToString(), "OK");

            if (CrossConnectivity.Current.IsConnected)
            {
                this.DisplayAlert("Device Network", "Connected", "OK");
            }
            else
            {
                this.DisplayAlert("Device Network", "Not connected", "OK");
            }
        }
    }
}
