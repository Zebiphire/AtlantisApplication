using System;
using System.Collections.Generic;
using System.Text;

namespace AtlantisApplication
{
    public static class ServerInfo
    {
        public static Uri AuthorizationEndpoint = new Uri("https://partners-login.eliotbylegrand.com/authorize");
        public static Uri TokenEndpoint = new Uri("https://partners-login.eliotbylegrand.com/token");
        public static Uri ApiEndpoint = new Uri("https://partners-login.eliotbylegrand.com/whoami");
        public static Uri redirect_uri = new Uri("https://login.microsoftonline.com/tfp/oauth2/nativeclient");
        public static string client_id = "358ca400-fdf6-4357-8cca-27caa6699197";
        public static string client_secret = "*d,|`89Jnx/Ea5O8y$T724W4";
        public static string response_type = "code";
    }
}
