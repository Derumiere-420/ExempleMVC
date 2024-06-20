using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations.Radio
{
    public class Radio : IRadio
    {
        public Radio()
        {
            IsRadioOn = false;
            RadioName = this.GetType().Name;
        }
        public IBattery _battery { get; set; }
        public bool IsRadioOn { get; set; }
        public string RadioName { get; set; }

        public string BatteryType()
        {
            return _battery.GetType().Name;
        }

        public bool GetRadioStatus()
        {
            return IsRadioOn;
        }

        public string TurnOff()
        {
            IsRadioOn = false;
            return _battery.PowerOff();
        }

        public string TurnOn()
        {
            IsRadioOn = true;
            return _battery.PowerOn();
        }

        public virtual string SerialNumber()
        {
            return "Serial : ";
        }
    }
}
