using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Models;
using AtlantisApplication.ViewModels;
using AtlantisApplication.Views.DisplayData;
using AtlantisApplication.Views.SensorPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseCO2 : ContentPage
	{
	    private long _result1;
	    private long _result2;
	    List<CO2> listCustomCO2 = new List<CO2>();

        public ChooseCO2 ()
		{
			InitializeComponent ();
		}

        private void ListCO2_OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new co2Sensor());
        }

	    private async Task CustomListCO2_OnButtonClickedAsync(object sender, EventArgs e)
	    {
	        string TypeSensor = "humiditySensor";

	        var DateValue1 = Day1_Editor.Text;
	        var DateValue2 = Day2_Editor.Text;

	        _result1 = Convert.ToInt64(DateValue1);
	        _result2 = Convert.ToInt64(DateValue2);

	        listCustomCO2 = GetTempByIdRest.GetListCustomCO2s(TypeSensor, _result1, _result2);

	        await Navigation.PushAsync(new DisplayCustomCO2(listCustomCO2));
	    }
    }
}