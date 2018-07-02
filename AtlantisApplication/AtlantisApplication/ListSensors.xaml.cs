﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AtlantisApplication.Data;
using AtlantisApplication.Models;
using AtlantisApplication.Views.SensorPage;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListSensors : ContentPage
	{
	    public List<DeviceAPI> ListDeviceAPI = new List<DeviceAPI>();

	    //public GetListSensorsRest getListSensorsRest = new GetListSensorsRest();

        public ListSensors ()
		{
			InitializeComponent ();

            ListDeviceAPI = GetListRest();

		    listView.ItemsSource = ListDeviceAPI;
		}

	   

	    public static List<DeviceAPI> GetListRest()
	    {
	        var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyTemperatureGetListDevicesUri);
	        var listJsonDevice = JsonConvert.DeserializeObject<List<DeviceAPI>>(jsonUrlDevices);
            List<DeviceAPI> listDevice = new List<DeviceAPI>();

	        Console.WriteLine("jsonUrlDevicesjsonUrlDevicesjsonUrlDevicesjsonUrlDevices");
            Console.WriteLine(jsonUrlDevices.ToString());

	        foreach (var urlresult in listJsonDevice)
	        {
	            listDevice.Add(new DeviceAPI
	            {
	                addressMac = urlresult.addressMac,
                    name = urlresult.name,
	                nameDeviceType = urlresult.nameDeviceType,
	                disabled = urlresult.disabled,
	                id = urlresult.id,
	                lastName = urlresult.lastName,
                    name
                });
	        }
	        return listDevice;
	    }

        private void OnRefresh(object sender, EventArgs e)
        {
            InitializeComponent();

            ListDeviceAPI = GetListRest();

            listView.ItemsSource = ListDeviceAPI;
        }
	    //private INavigation _navigation;
        private async void OnItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            //listView.SetBinding(ListView.SelectedItemProperty, "SelectedItem");
            /*var item = e.SelectedItem;
            var newpage = new temperatureSensor(item.addressMac);
            await Navigation.PushAsync(newpage);*/

            ListView myList = (ListView)sender;
            var adress = (myList.SelectedItem as DeviceAPI);
            int id = adress.id;
          //  await Application.Current.MainPage.Navigation.PushAsync(new temperatureSensor(id));


            //await Navigation.PushAsync(new temperatureSensor(adress));


            //myList.SelectedItem = null; // de-select the row
            //await _navigation.PushAsync(new temperatureSensor(adress));
            /*var item = e.SelectedItem;
            string txt = item.ToString();
            DisplayAlert("Alert", txt, "OK");*/
        }
    }
}