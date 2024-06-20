using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Battery
{
    public class AlkalineBattery : IBattery
    {
        public string PowerOn()
        {
            return "Alkaline Battery is powering on.";
        }

        public string PowerOff()
        {
            return "Alkaline Battery is powering off.";
        }
    }

}
