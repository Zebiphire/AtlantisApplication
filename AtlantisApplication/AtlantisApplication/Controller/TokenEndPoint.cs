using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AtlantisApplication.Controller
{
    public class TokenEndPoint
    {
        static async Task<string> TokenEndPointResponseAsync()
        {
            async Task TaskMethodAsync()
            {
                AuthorizationEndPoint test = new AuthorizationEndPoint();
            }

            await TaskMethodAsync();

            var url = "https://partners-login.eliotbylegrand.com/authorize";
            var client = new WebClient();
            var method = "POST";
            var parameters = new NameValueCollection
            {
                { "client_id", "358ca400-fdf6-4357-8cca-27caa6699197" },
                { "grant_type", "authorization_code" },
                { "code", "eyJraWQiOiJjcGltY29yZV8wOTI1MjAxNSIsInZlciI6IjEuMCIsInppcCI6IkRlZmxhdGUiLCJzZXIiOiIxLjAifQ..fdn8X7Ch1WCssf8_.qCy_s3QknQXL_SAZKH8YtyArVKNR9VHXnWnJSnzBQlfGcpOo80GWFSxcpFWw215NzrC6o5nUjyhdhPqMRc7ZdY4tEKuLsdDu4xJJJ6cn4bUfGB9XcSIRv6YYlCi1ACMNN9K3JplqqTHnAkSPvdRmB5mUAgonpG8R8f_BmfU4BAGQ9E9HwesNJ8sy9k9Vwz-jEGW1LG4HZ8pMj_jmHQTFFI243A9gBQeuA0AwDg-0DFEeUuIbvQRm0dRPIJ5wxBFESF-nFowV8MPWxKnE7VAqm-_Bj0axnFpudUL6ZBsH8-QpbqPb12kHh2zXpIh41l6QZye-iPoxkoI2gotR7Y5SdChuOu4XaCruKaZ3IVhjpAUgWWY_nZr3Jzn5EY1VovQrko8e_4mqcXnypAiCdYSt057DJcSei41zACMcYR1VhniO-Q2WtbxtpfYgs0R9Bb7MtFBtbyWZ2tklZMZnoQEHItlzp94KGn5MK98yNtgzLUdJc8MsykzL4zjzJ8IIts7q6_apAdS4LizqsNosgmcj_DdvGWnssQ_z8PoeEbnbJvuK0FqE9Z29y-bbQmaX6VImnnjurhjawkjsIFImXQ_wx0Mu8HDExu3vI6p4s99mPUBGahLK7ASN1CwwXZ5Nf6KPchd4Ae_LJQ16BfM7Q-E-WBSkRDihpBWmfQFCoY3gsxjWjxxod-LCuGkSwH2BeZ8sP6GKBFmbtR2wpdhZAm3LKWDLJmJcnvtYqOzaLtto2K3YQ5VxFxZ4rnxXXf0YdU0IF6Kq-hY50ofS4x1FLRBn7ByFux6KrZ5br7CsOKB-b4RI7AfNu7ZeAUbiL25b1qJr8c5roLmevT0v.2rHcA0vr3El2v-3OjFd2-g" },
                { "client_secret", "*d,|`89Jnx/Ea5O8y$T724W4" }
            };

            var responseData = client.UploadValues(url, method, parameters);
            var responseString = Encoding.UTF8.GetString(responseData);
            return responseString;
        }
    }
}
