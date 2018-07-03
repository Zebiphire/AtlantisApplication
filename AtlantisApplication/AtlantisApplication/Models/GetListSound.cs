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
            var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.GeoffreySoundWebUri);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Sound>>(jsonUrlDevices);
            List<Sound> listDevice = new List<Sound>();
            foreach (var urlresult in listJsonDevice)
            {
                listDevice.Add(new Sound
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
