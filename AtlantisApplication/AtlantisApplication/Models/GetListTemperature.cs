using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    public class GetListTemperature
    {
        public static List<Temperature> GetTemperaturesList()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyTemperatureWebUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Temperature>>(jsonUrlDevices);
            List<Temperature> listDevice = new List<Temperature>();

            foreach (var urlresult in listJsonDevice)
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
