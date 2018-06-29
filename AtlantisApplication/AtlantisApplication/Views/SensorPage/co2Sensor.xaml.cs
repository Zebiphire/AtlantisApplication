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
	public partial class co2Sensor : ContentPage
	{
	    public List<CO2> ListCO2 = new List<CO2>();

        public co2Sensor ()
		{
		    InitializeComponent();

		    ListCO2 = GetListCO2.GetCO2List();

		    listC.ItemsSource = ListCO2;
        }
	}
}