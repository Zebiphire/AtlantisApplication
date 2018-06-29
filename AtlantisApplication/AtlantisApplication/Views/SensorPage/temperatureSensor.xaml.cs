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
        GetListTemperature getListTemperature = new GetListTemperature();

        public temperatureSensor()
        {
            InitializeComponent();

            ListTemperature = GetTemperaturesList();

            listTemp.ItemsSource = ListTemperature;

        }

        private void OnNavigateButtonClicked(object sender, EventArgs e)
        {

        }

        public static List<Temperature> GetTemperaturesList()
        {

                var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyTemperatureUri);
                var listJsonDevice = JsonConvert.DeserializeObject<RootTemperature>(jsonUrlDevices);
  
                List<Temperature> listDevice = new List<Temperature>();
                foreach (var urlresult in listJsonDevice.Temperature)
                {
                    listDevice.Add(new Temperature
                    {
                        id = urlresult.id,
                        deviceType = urlresult.deviceType,
                        dateType = urlresult.dateType,
                        value = urlresult.value,
                        date = urlresult.date
                    });
                }

                return listDevice;
        }
    }
}
