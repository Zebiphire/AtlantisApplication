using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    public class GetTempByIdRest
    {
        public static string _authorizationKey;


        public static List<Temperature> GetListCustomTemperatures(string idType, long day1, long day2)
        {
            string Url = "http://10.167.128.145:8080/mobile-transaction/data/date-range?startDate=" + day1 + "&endDate=" + day2 + "&deviceType=" + idType;
            var jsonUrlDevices = new WebClient().DownloadString(Url);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Temperature>>(jsonUrlDevices);

            List<Temperature> listTemp = new List<Temperature>();

            foreach (var urlresult in listJsonDevice)
            {
                listTemp.Add(new Temperature
                {
                    id = urlresult.id,
                    deviceType = urlresult.deviceType,
                    dateType = urlresult.dateType,
                    value = urlresult.value,
                    date = urlresult.date
                });
            }
            return listTemp;
        }

        //GeoffreyTemperatureGetListWebTempUri

        public static async Task<HttpClient> GetListDateTask(string idType, long day1, long day2)
        {
            string Url = "http://10.167.128.145:8080/mobile-transaction/data/date-range?startDate=" + day1 + "&endDate=" + day2 + "&deviceType=" + idType;
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(_authorizationKey))
            {
                _authorizationKey = await client.GetStringAsync(Url);
                _authorizationKey = JsonConvert.DeserializeObject<string>(_authorizationKey);
            }

            client.DefaultRequestHeaders.Add("Authorization", _authorizationKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            Console.WriteLine("GetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTaskGetListDateTask");
            Console.WriteLine(client);

            return client;
        }




        public static void SendDateToUrl(string json)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(ServerInfo.GeoffreyTemperatureGetListTempUri);
            //httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public class Date
        {
            public string typeDevice;
            public long BeginDate;
            public long EndDate;

        }
    }
}
