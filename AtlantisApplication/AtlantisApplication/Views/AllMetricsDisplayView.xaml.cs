using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Models;
using AtlantisApplication.Views.SensorPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllMetricsDisplayView : ContentPage
	{
		public AllMetricsDisplayView ()
		{
			InitializeComponent ();
		}

        public void GoOnTemperaturePage(object sender, EventArgs e)
        {
            
            try
            {
                App.Current.MainPage = new NavigationPage(new temperatureSensor());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error, no connection to REST", ex.Message, "OK");
            }

            //await Navigation.PushAsync(new temperatureSensor());
            // this.Navigation.PushAsync(new temperatureSensor());
        }

        public async void GoOnHumidityPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new humiditySensor());
            //await Navigation.PushAsync(new humiditySensor());
            // this.Navigation.PushAsync(new humiditySensor());
        }

        private void GoOnCO2Page(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new co2Sensor());
        }

        private void GoOnSoundLevelPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new soundLevelSensor());
        }
    }
}