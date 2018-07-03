using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Models;
using AtlantisApplication.ViewModels;
using AtlantisApplication.Views.SensorPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseTemperature : ContentPage
	{
	    private long _result1;
	    private long _result2;
	    List<Temperature> listCustomTemp = new List<Temperature>();

        public ChooseTemperature ()
		{
			InitializeComponent ();
		}

        private void ListTemp_OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new temperatureSensor());
        }


	    public async Task CustomListTemp_OnButtonClickedAsync(object sender, EventArgs e)
	    {
	        string TypeSensor = "temperatureSensor";

	     /*   DateTime DateValue1 = DateTime.Parse(Day1_Editor.Text);
	        DateTime DateValue2 = DateTime.Parse(Day2_Editor.Text);*/

            _result1 = 1530263864718;
	        _result2 = 1530274077664;

	        listCustomTemp = GetTempByIdRest.GetListCustomTemperatures(TypeSensor, _result1, _result2);

	        await Navigation.PushAsync(new DisplayCustomTemperature(listCustomTemp));
	    }
    }
}