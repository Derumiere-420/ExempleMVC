using ServiceRadioFactory.Services.Implementations.Battery;
using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Factories
{
    public class BatteryFactory : IBatteryFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public BatteryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }

        public IBattery CreateBattery(string type)
        {
            IBattery battery;
            switch (type)
            {
                case "LithiumBattery":
                    battery = _serviceProvider.GetRequiredService<LithiumBattery>();
                    break;
                case "NickelCadmiumBattery":
                    battery = _serviceProvider.GetRequiredService<NickelCadmiumBattery>();
                    break;
                case "AlkalineBattery":
                    battery = _serviceProvider.GetRequiredService<AlkalineBattery>();
                    break;
                default:
                    battery = _serviceProvider.GetRequiredService<LithiumBattery>();
                    break;
            }

            return battery;
        }

    }

}
