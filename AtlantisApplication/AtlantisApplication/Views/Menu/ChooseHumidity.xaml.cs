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
	public partial class ChooseHumidity : ContentPage
	{
	    private long _result1;
	    private long _result2;
	    List<Humidity> listCustomHumidity = new List<Humidity>();

        public ChooseHumidity ()
		{
			InitializeComponent ();
		}

        private void ListHumidity_OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new humiditySensor());
        }

	    private async Task CustomListHumidity_OnButtonClickedAsync(object sender, EventArgs e)
	    {
	        string TypeSensor = "humiditySensor";

	        var DateValue1 = Day1_Editor.Text;
	        var DateValue2 = Day2_Editor.Text;

	        _result1 = Convert.ToInt64(DateValue1);
	        _result2 = Convert.ToInt64(DateValue2);

	        listCustomHumidity = GetTempByIdRest.GetListCustomHumiditys(TypeSensor, _result1, _result2);

	        await Navigation.PushAsync(new DisplayCustomHumidity(listCustomHumidity));
	    }
    }
}