using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Models
{
    public class Radio
    {
        private readonly IBattery _battery;

        public string RadioName { get; set; }
        public bool isRadioOn { get; set; }

        public Radio(IBattery battery, string radioName)
        {
            _battery = battery ?? throw new ArgumentNullException(nameof(battery));
            RadioName = radioName;
            isRadioOn = false;
        }

        public string TurnOn()
        {
            isRadioOn = true;
            return _battery.PowerOn();
        }

        public string TurnOff()
        {
            isRadioOn = false;
            return _battery.PowerOff();
        }

        public string BatteryType()
        {
            return _battery.GetType().Name;
        }

        public bool GetRadioStatus() 
        {
            return isRadioOn;
        }
    }

}
