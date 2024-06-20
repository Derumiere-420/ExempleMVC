using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Services.Implementations
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
