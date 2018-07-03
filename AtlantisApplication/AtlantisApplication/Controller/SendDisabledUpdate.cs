using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using AtlantisApplication.Data;
using Newtonsoft.Json;

namespace AtlantisApplication.Controller
{
    class SendDisabledUpdate
    {

        public class UpdateDevice
        {
            public int id { get; set; }
            public string action { get; set; }
        }

        public static async System.Threading.Tasks.Task SendIsDisabledUpdateAsync(int Id, string Action)
        {

            UpdateDevice updateDevice = new UpdateDevice
            {
                id = Id,
                action = Action
            };

            var jsonMetric = JsonConvert.SerializeObject(updateDevice);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(ServerInfo.GeoffreyTemperatureUpdateDisabledDeviceUri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsonMetric);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
