using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.Data;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListSensorsRest
    {
        public static List<DeviceAPI> GetListSensors()
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
