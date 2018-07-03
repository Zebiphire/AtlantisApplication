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
	public partial class ChooseSound : ContentPage
	{
	    private long _result1;
	    private long _result2;
	    List<Sound> listCustomSound = new List<Sound>();

        public ChooseSound ()
		{
			InitializeComponent ();
		}

        private void ListSound_OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new soundLevelSensor());
        }

	    public async Task CustomListSound_OnButtonClickedAsync(object sender, EventArgs e)
	    {
	        string TypeSensor = "soundLevelSensor";

	        var DateValue1 = Day1_Editor.Text;
	        var DateValue2 = Day2_Editor.Text;

	        _result1 = Convert.ToInt64(DateValue1);
	        _result2 = Convert.ToInt64(DateValue2);

	        listCustomSound = GetTempByIdRest.GetListCustomSounds(TypeSensor, _result1, _result2);

	        await Navigation.PushAsync(new DisplayCustomSound(listCustomSound));
	    }
    }
}