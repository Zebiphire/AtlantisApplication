using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListAtmosheric
    {
        public static List<Atmospheric> GetAtmoshericsList()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Atmospheric>>(jsonUrlDevices);
            string DAY = "";
            string WEEK = "";
            string MONTH = "";
            string YEAR = "";
            List<Atmospheric> listDevice = new List<Atmospheric>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Atmospheric
                {
                    DAY = urlresult.DAY,
                    WEEK = urlresult.WEEK,
                    MONTH = urlresult.MONTH,
                    YEAR = urlresult.YEAR
                });
            }
            return listDevice;
        }
    }
}
