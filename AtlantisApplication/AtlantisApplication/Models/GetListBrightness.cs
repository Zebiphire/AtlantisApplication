using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListBrightness
    {
        public static List<Brightness> GetBrightnessList()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Brightness>>(jsonUrlDevices);
            string DAY = "";
            string WEEK = "";
            string MONTH = "";
            string YEAR = "";
            List<Brightness> listDevice = new List<Brightness>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Brightness
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
