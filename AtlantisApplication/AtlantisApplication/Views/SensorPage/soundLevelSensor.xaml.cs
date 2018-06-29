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
	public partial class soundLevelSensor : ContentPage
	{
	    public List<Sound> ListSound = new List<Sound>();

        public soundLevelSensor ()
		{
		    InitializeComponent();

		    ListSound = GetListSound.GetSoundList();

		    listS.ItemsSource = ListSound;
        }
	}
}