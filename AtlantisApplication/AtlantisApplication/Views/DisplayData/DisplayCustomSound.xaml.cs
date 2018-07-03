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
	public partial class DisplayCustomSound : ContentPage
	{
	    public List<Sound> ListSound = new List<Sound>();

        public DisplayCustomSound (List<Sound> listCustomSound)
		{
		    InitializeComponent();

		    ListSound = listCustomSound;

		    listSound.ItemsSource = ListSound;
        }
	}
}