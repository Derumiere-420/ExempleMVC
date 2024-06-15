using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Models
{
    public class Radio
    {
        private readonly IBattery _battery;

        public Radio(IBattery battery)
        {
            _battery = battery ?? throw new ArgumentNullException(nameof(battery));
        }

        public string TurnOn()
        {
            return _battery.PowerOn();
        }

        public string TurnOff()
        {
            return _battery.PowerOff();
        }
    }

}
