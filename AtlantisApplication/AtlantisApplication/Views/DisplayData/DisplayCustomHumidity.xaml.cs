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
	public partial class DisplayCustomHumidity : ContentPage
	{
	    public List<Humidity> ListHumidity = new List<Humidity>();

        public DisplayCustomHumidity (List<Humidity> listCustomHumidity)
		{
		    InitializeComponent();

		    ListHumidity = listCustomHumidity;

		    listHumidity.ItemsSource = ListHumidity;
        }
	}
}