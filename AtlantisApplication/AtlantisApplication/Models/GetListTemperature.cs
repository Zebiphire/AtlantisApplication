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
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Temperature>>(jsonUrlDevices);
            string DAY = "";
            string WEEK = "";
            string MONTH = "";
            string YEAR = "";
            List<Temperature> listDevice = new List<Temperature>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Temperature
                {
                   /* DAY = urlresult.DAY,
                    WEEK = urlresult.WEEK,
                    MONTH = urlresult.MONTH,
                    YEAR = urlresult.YEAR*/
                });
            }
            return listDevice;
        }
    }
}
