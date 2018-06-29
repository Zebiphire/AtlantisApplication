using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Models;
using AtlantisApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.SensorPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class humiditySensor : ContentPage
	{
	    public List<Humidity> ListHumidity = new List<Humidity>();

        public humiditySensor ()
		{
		    InitializeComponent();

		    ListHumidity = GetListHumidity.GetHumidityList();

		    listHum.ItemsSource = ListHumidity;
        }
	}
}