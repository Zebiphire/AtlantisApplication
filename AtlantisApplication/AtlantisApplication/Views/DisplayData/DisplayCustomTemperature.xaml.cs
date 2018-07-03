using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayCustomTemperature : ContentPage
    {
        public List<Temperature> ListTemperature = new List<Temperature>();

        public DisplayCustomTemperature(List<Temperature> listCustomTemp)
        {
            InitializeComponent();

            ListTemperature = listCustomTemp;

            listCT.ItemsSource = ListTemperature;
        }

    }
}