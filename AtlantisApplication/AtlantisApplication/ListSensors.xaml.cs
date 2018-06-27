using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Data;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantisApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListSensors : ContentPage
	{
		public ListSensors ()
		{
			InitializeComponent ();
        }

	    public List<DeviceAPI> ListDeviceAPI = new List<DeviceAPI>();

	    

	    public void test()
	    {
	        ListDeviceAPI = GetListRest();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

	    public static List<DeviceAPI> GetListRest()
	    {
	        var jsonUrlDevices = new WebClient().DownloadString("http://wcfwebservice.azurewebsites.net/Service.svc/devices/devices");
	        var listJsonDevice = JsonConvert.DeserializeObject<List<DeviceAPI>>(jsonUrlDevices);
	        string adressMacDevice = "";
	        string nomDevice = "";
	        string typeDevicesDevice = "";
	        List<DeviceAPI> listDevice = new List<DeviceAPI>();
	        foreach (var urlresult in listJsonDevice)
	        {
	            listDevice.Add(new DeviceAPI
	            {
	                addressMac = urlresult.addressMac,
	                name = urlresult.name,
	                typeDevices = urlresult.typeDevices
	            });
	        }
	        return listDevice;
	    }
    }
}