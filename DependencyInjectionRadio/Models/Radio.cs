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

        public void TurnOn()
        {
            _battery.PowerOn();
            Console.WriteLine("Radio is turned on.");
        }

        public void TurnOff()
        {
            _battery.PowerOff();
            Console.WriteLine("Radio is turned off.");
        }
    }

}
