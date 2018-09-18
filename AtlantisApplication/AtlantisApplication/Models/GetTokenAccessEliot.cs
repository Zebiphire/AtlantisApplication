using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AtlantisApplication.ViewModels;
using Newtonsoft.Json;
using Xamarin.Auth;

namespace AtlantisApplication.Models
{
    public class GetTokenAccessEliot
    {
        public static async System.Threading.Tasks.Task<List<Token>> GetTokenAsync(string Code)
        {
            List<Token> listToken = new List<Token>();
            string resultToken = "";

             /* AccessToken parameters = new AccessToken
              {
                  client_id = "358ca400-fdf6-4357-8cca-27caa6699197" ,
                  grant_type = "358ca400-fdf6-4357-8cca-27caa6699197",
                  code = Code,
                  client_secret = "*d,|`89Jnx/Ea5O8y$T724W4"
              };*/


            var client = new HttpClient();
            client.BaseAddress = new Uri("https://partners-login.eliotbylegrand.com/token");
            var request = new HttpRequestMessage(HttpMethod.Post, "/token");

            var nvc = new List<KeyValuePair<string, string>>();
            nvc.Add(new KeyValuePair<string, string>("client_id", "358ca400-fdf6-4357-8cca-27caa6699197"));
            nvc.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            nvc.Add(new KeyValuePair<string, string>("code", Code));
            nvc.Add(new KeyValuePair<string, string>("client_secret", "*d,|`89Jnx/Ea5O8y$T724W4"));

            request.Content = new FormUrlEncodedContent(nvc);

            //var response = await client.SendAsync(request);

            using (HttpResponseMessage res = await client.SendAsync(request))
            {
                using (HttpContent content = res.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    result = resultToken;
                }
            }
            


            /*var jsonUrlDevices = new WebClient().DownloadString(ServerInfo.TokenEndpoint);
            var listJsonDevice = JsonConvert.DeserializeObject<List<Token>>(jsonUrlDevices);

            foreach (var urlresult in listJsonDevice)
            {
                listToken.Add(new Token
                {
                    access_token = urlresult.access_token,
                    id_token = urlresult.id_token,
                    token_type = urlresult.token_type,
                    not_before = urlresult.not_before,
                    expires_in = urlresult.expires_in,
                    expires_on = urlresult.expires_on,
                    resource = urlresult.resource,
                    id_token_expires_in = urlresult.id_token_expires_in,
                    profile_info = urlresult.profile_info,
                    refresh_token = urlresult.refresh_token,
                    refresh_token_expires_in = urlresult.refresh_token_expires_in
                });
            }*/
            //return listToken;

            /* var jsonMetric = JsonConvert.SerializeObject(parameters);

             var httpWebRequest = (HttpWebRequest)WebRequest.Create(ServerInfo.TokenEndpoint);
             httpWebRequest.ContentType = "application/x-www-form-urlencoded";
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
             }*/


            /*var nvc = new List<KeyValuePair<string, string>>();
            nvc.Add(new KeyValuePair<string, string>("client_id", "358ca400-fdf6-4357-8cca-27caa6699197"));
            nvc.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            nvc.Add(new KeyValuePair<string, string>("code", Code));
            nvc.Add(new KeyValuePair<string, string>("client_secret", "*d,|`89Jnx/Ea5O8y$T724W4"));*/

            /* var client = new HttpClient();
             client.BaseAddress = new Uri("https://partners-login.eliotbylegrand.com/token");
             string jsonData = string.Format(@"{""client_id"":""358ca400-fdf6-4357-8cca-27caa6699197"",""grant_type"":""358ca400-fdf6-4357-8cca-27caa6699197"",""code"" : "+{0}+", ""client_secret"" : ""*d,|`89Jnx/Ea5O8y$T724W4""}";}, Code);
             var content = new StringContent(jsonData, Encoding.UTF8, "application/x-www-form-urlencoded");
             HttpResponseMessage response = Task.Run(async () => await client.GetAsync("https://partners-login.eliotbylegrand.com/token")).Result;
             var result = await response.Content.ReadAsStringAsync();*/


            /*var uri = new Uri("https://partners-login.eliotbylegrand.com/token");
            var json = JsonConvert.SerializeObject(parameters);
            var content = new StringContent(string.Join("&", parameters), Encoding.UTF8, "application/x-www-form-urlencoded");
            var content = new StringContent(json, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = null;
            var client = new HttpClient();
            response = await client.PostAsync(uri, content);*/


           /* var client = new HttpClient();
            client.BaseAddress = new Uri(ServerInfo.TokenEndpoint.ToString());
            var request = new HttpRequestMessage(HttpMethod.Post, "/token");

            var requestContent = string.Format(ServerInfo.TokenEndpoint+ "client_id=358ca400-fdf6-4357-8cca-27caa6699197&grant_type=authorization_code&code={0}&client_secret=*d,|`89Jnx/Ea5O8y$T724W4", Code);
            request.Content = new StringContent(requestContent, Encoding.UTF8, "application/x-www-form-urlencoded");

             using (HttpResponseMessage res = await client.SendAsync(request))
             {
                 using (HttpContent content = res.Content)
                 {
                     string result = await content.ReadAsStringAsync();

                   }
             }*/

            //return listToken;

            /* var httpWebRequest = (HttpWebRequest)WebRequest.Create(ServerInfo.TokenEndpoint);
             httpWebRequest.ContentType = "application/x-www-form-urlencoded";
             httpWebRequest.Method = "POST";
             using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
             {
                 streamWriter.Write(nvc);
                 streamWriter.Flush();
                 streamWriter.Close();
             }*/

            /* var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
             using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
             {
                 var result = streamReader.ReadToEnd();
             }*/

            return listToken;
        } 
    }
}
