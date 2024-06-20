using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations
{
    public class LithiumBattery : IBattery
    {
        public string PowerOn()
        {
            return("Lithium Battery is powering on.");
        }

        public string PowerOff()
        {
           return("Lithium Battery is powering off.");
        }
    }

}
