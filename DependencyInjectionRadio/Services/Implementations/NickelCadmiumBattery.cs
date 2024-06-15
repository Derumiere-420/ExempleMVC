using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class NickelCadmiumBattery : IBattery
    {
        public string PowerOn()
        {
            return("Nickel-Cadmium Battery is powering on the device.");
        }

        public string PowerOff()
        {
            return("Nickel-Cadmium Battery is powering off the device.");
        }
    }

}
