using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Services.Implementations
{
    public class AlkalineBattery : IBattery
    {
        public void PowerOn()
        {
            Console.WriteLine("Alkaline Battery is powering on the device.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Alkaline Battery is powering off the device.");
        }
    }

}
