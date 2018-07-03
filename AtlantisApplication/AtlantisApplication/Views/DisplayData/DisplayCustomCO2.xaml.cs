using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.DisplayData
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayCustomCO2 : ContentPage
	{
	    public List<CO2> ListCO2 = new List<CO2>();

        public DisplayCustomCO2 (List<CO2> listCustomCO2)
		{
		    InitializeComponent();

		    ListCO2 = listCustomCO2;

		    listCO2.ItemsSource = ListCO2;
        }
	}
}