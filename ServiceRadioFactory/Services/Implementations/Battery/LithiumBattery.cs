using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Battery
{
    public class LithiumBattery : IBattery
    {
        public string PowerOn()
        {
            return "Lithium Battery is powering on.";
        }

        public string PowerOff()
        {
            return "Lithium Battery is powering off.";
        }
    }

}
