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

        public temperatureSensor()
        {
            InitializeComponent();

            ListTemperature = GetListTemperature.GetTemperaturesList();

            listTemp.ItemsSource = ListTemperature;

        }

        private long _result1;
        private long _result2;
        List<Temperature> listCustomTemp = new List<Temperature>();

        public async Task DoneButton_OnClickedAsync(object sender, EventArgs e)
        {
            string TypeSensor = "temperatureSensor";

            var DateValue1 = Day1_Editor.Text;
            var DateValue2 = Day2_Editor.Text;

              _result1 = Convert.ToInt64(DateValue1);
              _result2 = Convert.ToInt64(DateValue2);

            listCustomTemp = GetTempByIdRest.GetListCustomTemperatures(TypeSensor, _result1, _result2);

            await Navigation.PushAsync(new DisplayCustomTemperature(listCustomTemp));
        }
    }
}
