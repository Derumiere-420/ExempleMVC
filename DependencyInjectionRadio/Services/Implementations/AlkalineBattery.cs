using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class AlkalineBattery : IBattery
    {
        public string PowerOn()
        {
           return("Alkaline Battery is powering on the device.");
        }

        public string PowerOff()
        {
            return("Alkaline Battery is powering off the device.");
        }
    }

}
