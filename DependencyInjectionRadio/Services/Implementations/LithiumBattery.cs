using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class LithiumBattery : IBattery
    {
        public string PowerOn()
        {
            return("Lithium Battery is powering on the device.");
        }

        public string PowerOff()
        {
           return("Lithium Battery is powering off the device.");
        }
    }

}
