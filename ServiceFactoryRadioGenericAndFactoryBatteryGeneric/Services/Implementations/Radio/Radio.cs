using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Radio
{
    public class Radio : IRadio
    {

        public bool IsRadioOn { get; set; }
        public string RadioName { get; set; }
        public IBattery Battery { get; set; }

        public Radio()
        {
            
        }
        public Radio(IBattery battery)
        {
            IsRadioOn = false;
            Battery = battery;
        }
        public string BatteryType()
        {
            return Battery.GetType().Name;
        }

        public bool GetRadioStatus()
        {
            return IsRadioOn;
        }

        public string TurnOff()
        {
            IsRadioOn = false;
            return Battery.PowerOff();
        }

        public string TurnOn()
        {
            IsRadioOn = true;
            return Battery.PowerOn();
        }



    }
}
