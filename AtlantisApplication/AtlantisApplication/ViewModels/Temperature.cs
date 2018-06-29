using System;
using System.Collections.Generic;
using System.Text;

namespace AtlantisApplication.ViewModels
{
    public class Temperature
    {

        public int id { get; set; }
        public string deviceType { get; set; }
        public string dateType { get; set; }
        public double value { get; set; }
        public object date { get; set; }


        /*
        public string DAY { get; set; }
        public string WEEK { get; set; }
        public string MONTH { get; set; }
        public string YEAR { get; set; }*/
    }
    public class RootTemperature
    {
        public List<Temperature> Temperature { get; set; }
    }
}
