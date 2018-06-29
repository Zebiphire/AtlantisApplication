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
        public static List<Temperature>GetTempById(string Id)
        {
            var url = "???";
            var client = new WebClient();
            var method = "GET"; 
            var parameters = new NameValueCollection
            {
                { "id", "Id" },
            };

            var responseData = client.UploadValues(url, method, parameters);
            //var responseString = Encoding.UTF8.GetString(responseData);


            List<Temperature> listTemp = new List<Temperature>();
            foreach (var urlresult in responseData)
            {
                listTemp.Add(new Temperature
                {
                    /*addressMac = urlresult.addressMac,
                    name = urlresult.name,
                    typeDevices = urlresult.typeDevices*/
                });
            }
            return listTemp;

        }
    }
}
