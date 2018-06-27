using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AtlantisApplication.Data
{
    public class DeviceAPIManager
    {
        const string Url = "http://wcfwebservice.azurewebsites.net/Service.svc/calculs/devices";
        private string _authorizationKey;

        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(_authorizationKey))
            {
                _authorizationKey = await client.GetStringAsync(Url);
                _authorizationKey = JsonConvert.DeserializeObject<string>(_authorizationKey);
            }

            client.DefaultRequestHeaders.Add("Authorization", _authorizationKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<DeviceAPI>> GetAll()
        {
            HttpClient client = await GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<DeviceAPI>>(result);
        }
    }
}
