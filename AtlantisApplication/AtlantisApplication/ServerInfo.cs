using System;
using System.Collections.Generic;
using System.Text;

namespace AtlantisApplication
{
    public static class ServerInfo
    {
        /*
         * URL pour la connexion Eliot et test de connexion
         */
        public static Uri AuthorizationEndpoint = new Uri("https://partners-login.eliotbylegrand.com/authorize");
        public static Uri TokenEndpoint = new Uri("https://partners-login.eliotbylegrand.com/token");
        public static Uri ApiEndpoint = new Uri("https://partners-login.eliotbylegrand.com/whoami");
        public static Uri redirect_uri = new Uri("https://login.microsoftonline.com/tfp/oauth2/nativeclient");
        public static string client_id = "358ca400-fdf6-4357-8cca-27caa6699197";
        public static string client_secret = "*d,|`89Jnx/Ea5O8y$T724W4";
        public static string response_type = "code";

        /*
         * Les Url de Geoffrey pour récupérer pour chaque type les 3 éléments de moyenne
         */
         public static Uri GeoffreyCustomDate = new Uri(" http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/date-range?startDate=");
         public static Uri GeoffreyDeviceWebUri = new Uri(" http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/devices");
         public static Uri GeoffreyTemperatureWebUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/temperature");
         public static Uri GeoffreySoundWebUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/sound-level");
         public static Uri GeoffreyCo2WebUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/co2");
         public static Uri GeoffreyHymidityWebUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/humidity");
         public static Uri GeoffreyTemperatureGetListWebTempUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/data/date-range");
         public static Uri GeoffreyTemperatureUpdateDisabledDeviceUri = new Uri("http://ec2-54-201-219-212.us-west-2.compute.amazonaws.com:8080/mobile-transaction/action");

        /*
         *  En local Url de Geoffrey pour récupérer pour chaque type les 3 éléments de moyenne 172.20.10.2
         */
        /*  public static Uri GeoffreyTemperatureUpdateDisabledDeviceUri = new Uri("http://10.167.128.145:8080/mobile-transaction/action");
          public static Uri GeoffreyDeviceWebUri = new Uri("http://10.167.128.145:8080/mobile-transaction/devices");
          public static Uri GeoffreyTemperatureGetListWebTempUri = new Uri("http://10.167.128.145/mobile-transaction/data/date-range");
          public static Uri GeoffreyTemperatureWebUri = new Uri("http://10.167.128.145:8080/mobile-transaction/data/temperature");
          public static Uri GeoffreySoundWebUri = new Uri("http://10.167.128.145:8080/mobile-transaction/data/sound-level");
          public static Uri GeoffreyCo2WebUri = new Uri("http://10.167.128.145:8080/mobile-transaction/data/co2");
          public static Uri GeoffreyHymidityWebUri = new Uri("http://10.167.128.145:8080/mobile-transaction/data/humidity");*/

        /*
         * Others
         */
        public static Uri GaetanUri = new Uri("https://login.microsoftonline.com/tfp/oauth2/nativeclient");
        public static Uri GeoffreyUri = new Uri("https://login.microsoftonline.com/tfp/oauth2/nativeclient");

    }
}
