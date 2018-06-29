using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;

namespace AtlantisApplication.Models
{
    class GetTempByIdRest
    {
       // public static List<Temperature>GetTempByDaysList(long day1, long day2)
        public static void GetTempByDaysList(long day1, long day2)
        {
            var url = ServerInfo.GeoffreyTemperatureGetListTempUri;
            var client = new WebClient();
            var method = "POST"; 
            var parameters = new Date
            {
                BeginDate = day1,
                EndDate = day2
            };


            var JsonDate = JsonConvert.SerializeObject(parameters);

            SendDateToUrl(JsonDate);

            //return

           // var responseData = client.UploadValues(url, method, parameters);
            //var responseString = Encoding.UTF8.GetString(responseData);


            /*  List<Temperature> listTemp = new List<Temperature>();
              foreach (var urlresult in responseData)
              {
                  listTemp.Add(new Temperature
                  {

                  });
              }
              return listTemp;*/
        }

        public static void SendDateToUrl(string json)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(ServerInfo.GeoffreyTemperatureGetListTempUri);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
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
            public long BeginDate;
            public long EndDate;

        }
    }
}
