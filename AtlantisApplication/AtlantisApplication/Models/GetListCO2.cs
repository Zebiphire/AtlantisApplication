using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListCO2
    {
        public static List<CO2> GetCO2List()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyCo2WebUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<CO2>>(jsonUrlDevices);
            string DAY = "";
            string WEEK = "";
            string MONTH = "";
            List<CO2> listDevice = new List<CO2>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new CO2
                {
                    dateType = urlresult.dateType,
                    value = urlresult.value,
                });
            }
            return listDevice;
        }
    }
}
