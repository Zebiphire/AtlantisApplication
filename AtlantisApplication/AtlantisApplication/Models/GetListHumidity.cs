using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListHumidity
    {
        public static List<Humidity> GetHumidityList()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyHymidityWebUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Humidity>>(jsonUrlDevices);
            List<Humidity> listDevice = new List<Humidity>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Humidity
                {
                    dateType = urlresult.dateType,
                    value = urlresult.value,
                });
            }
            return listDevice;
        }
    }
}
