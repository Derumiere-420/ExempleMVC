using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class LithiumBattery : IBattery
    {
        public void PowerOn()
        {
            Console.WriteLine("Lithium Battery is powering on the device.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Lithium Battery is powering off the device.");
        }
    }

}
