using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class NickelCadmiumBattery : IBattery
    {
        public void PowerOn()
        {
            Console.WriteLine("Nickel-Cadmium Battery is powering on the device.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Nickel-Cadmium Battery is powering off the device.");
        }
    }

}
