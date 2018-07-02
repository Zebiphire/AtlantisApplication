


using System;
using System.Collections.Generic;

namespace AtlantisApplication.Data
{
   // [JsonObject]
    public class DeviceAPI
    {


        public string addressMac { get; set; }
        public List<Employee> employees { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public TypeDevices typeDevices { get; set; }
        public string disabled { get; set; }

        public string nameDeviceType { get; set; }


        /*public long id;

        public string addressMac;

        public string employees;

        public string name;

        public string nameDeviceType;

        public string typeDevices;*/

        /* public long id { get; set; }

         public string addressMac { get; set; }

         public string employees { get; set; }

         public string name { get; set; }

         public string nameDeviceType { get; set; }

         public string typeDevices { get; set; }*/

        /*public bool PresenceSensor { get; set; }
        public int TemperatureSensor { get; set; }
        public int LightSensor { get; set; }
        public int AtmosphericPressureSensor { get; set; }
        public int HumiditySensor { get; set; }
        public int SoundLevelSensor { get; set; }
        public bool GPSSensor { get; set; }
        public bool C02LevelSensor { get; set; }
        public bool LED { get; set; }
        public bool Beeper { get; set; }*/

    }
}
