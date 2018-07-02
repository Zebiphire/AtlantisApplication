using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Data;
using AtlantisApplication.Models;
using AtlantisApplication.ViewModels;
using AtlantisApplication.Views.Login;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication.Views.SensorPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class temperatureSensor : ContentPage
    {
        public List<Temperature> ListTemperature = new List<Temperature>();
        //GetListTemperature getListTemperature = new GetListTemperature();

        public temperatureSensor()
        {
            InitializeComponent();

            ListTemperature = GetListTemperature.GetTemperaturesList();

            listTemp.ItemsSource = ListTemperature;

        }

        private void OnNavigateButtonClicked(object sender, EventArgs e)
        {
          
        }

        private void DoneButton_OnClicked(object sender, EventArgs e)
        {
           /* long day1 = (long)Convert.ToDouble(Day1_Editor);
            long day2 = (long)Convert.ToDouble(Day1_Editor);
            GetTempByIdRest.GetTempByDaysList(day1, day2);*/
        }
    }
}
