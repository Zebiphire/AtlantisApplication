using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace AtlantisApplication.Controller
{
    public class AuthorizationEndPoint
    {
        public static string AuthorizationEndPointResponse()
        {
            var url = "https://partners-login.eliotbylegrand.com/authorize";
            var client = new WebClient();
            var method = "POST";
            var parameters = new NameValueCollection
            {
                { "client_id", "358ca400-fdf6-4357-8cca-27caa6699197" },
                { "response_type", "code" },
                { "redirect_uri", "https://login.microsoftonline.com/tfp/oauth2/nativeclient" }
            };

            var responseData = client.UploadValues(url, method, parameters);
            string responseString = Encoding.UTF8.GetString(responseData);

            /*int found = 0;
            found = responseString.IndexOf("=");
            string test = responseString(found + 1);*/
            string test;
            test = responseString.Substring(63);

            Console.WriteLine(test);
            return responseString;



        }
    }
}
