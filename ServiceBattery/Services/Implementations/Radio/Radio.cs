using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations.Radio
{
    public class Radio : IRadio
    {
        public Radio()
        {
            
        }
        public Radio(IBattery battery, string radioName)
        {
            IsRadioOn = false;
            RadioName = radioName;
            Battery = battery;
        }
        public IBattery Battery { get; set; }
        public bool IsRadioOn { get; set; }
        public string RadioName { get; set; }

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
