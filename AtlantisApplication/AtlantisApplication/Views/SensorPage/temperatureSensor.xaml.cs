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

        private long _result1;
        private long _result2;
        List<Temperature> listCustomTemp = new List<Temperature>();

        public async Task DoneButton_OnClickedAsync(object sender, EventArgs e)
        {
            //Console.WriteLine("Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);Console.WriteLine(Day1_Editor);");
            //Console.WriteLine(Day1_Editor);
            //Console.WriteLine(Day2_Editor);

            string TypeSensor = "temperatureSensor";

            var DateValue1 = Day1_Editor.Text;
            var DateValue2 = Day2_Editor.Text;

            //_result1 = Int64.Parse("1530263864718");
            //_result2 = Int64.Parse("1530274077664");

              _result1 = Convert.ToInt64(DateValue1);
              _result2 = Convert.ToInt64(DateValue2);

            listCustomTemp = GetTempByIdRest.GetListCustomTemperatures(TypeSensor, _result1, _result2);


            await Navigation.PushAsync(new DisplayCustomTemperature(listCustomTemp));

        }


    }
}
