using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Services.Implementations
{
    public class NickelCadmiumBattery : IBattery
    {
        public string PowerOn()
        {
            return("Nickel-Cadmium Battery is powering on.");
        }

        public string PowerOff()
        {
            return("Nickel-Cadmium Battery is powering off.");
        }
    }

}
