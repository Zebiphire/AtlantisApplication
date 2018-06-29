using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using AtlantisApplication.Data;
using AtlantisApplication.ViewModels;

namespace AtlantisApplication.Models
{
    class GetTempByIdRest
    {
        public static List<Temperature>GetTempByDaysList(long day1, long day2)
        {
            var url = ServerInfo.GeoffreyTemperatureGetListTempUri;
            var client = new WebClient();
            var method = "POST"; 
            var parameters = new Date
            {
                BeginDate = day1,
                EndDate = day2
            };


            var jsonDate += new JavaScriptSerializer().Serialize(newMetricSend);




            //var responseData = client.UploadValues(url, method, parameters);
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

        public class Date
        {
            public long BeginDate;
            public long EndDate;

        }
    }
}
