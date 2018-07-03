using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Models;
using AtlantisApplication.Views.Menu;
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
                Navigation.PushModalAsync(new ChooseTemperature());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error, no connection to REST", ex.Message, "OK");
            }

        }

        public async void GoOnHumidityPage(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new ChooseHumidity());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error, no connection to REST", ex.Message, "OK");
            }
        }

        private void GoOnCO2Page(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new ChooseCO2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error, no connection to REST", ex.Message, "OK");
            }
        }

        private void GoOnSoundLevelPage(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushModalAsync(new ChooseSound());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error, no connection to REST", ex.Message, "OK");
            }
        }
    }
}