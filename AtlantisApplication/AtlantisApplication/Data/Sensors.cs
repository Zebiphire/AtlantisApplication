using System;
using System.Collections.Generic;
using System.Text;

namespace AtlantisApplication.Data
{
    class Sensors
    {
        public bool PresenceSensor { get; set; }
        public int TemperatureSensor { get; set; }
        public int LightSensor { get; set; }
        public int AtmosphericPressureSensor { get; set; }
        public int HumiditySensor { get; set; }
        public int SoundLevelSensor { get; set; }
        public bool GPSSensor { get; set; }
        public bool C02LevelSensor { get; set; }
        public bool LED { get; set; }
        public bool Beeper { get; set; }

    }
}
