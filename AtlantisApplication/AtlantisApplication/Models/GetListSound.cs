using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetListSound
    {
        public static List<Sound> GetSoundList()
        {
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreyUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Sound>>(jsonUrlDevices);
            string DAY = "";
            string WEEK = "";
            string MONTH = "";
            string YEAR = "";
            List<Sound> listDevice = new List<Sound>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Sound
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
