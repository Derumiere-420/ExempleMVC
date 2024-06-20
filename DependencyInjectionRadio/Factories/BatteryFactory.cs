using ServiceBatteryFactory.Services.Implementations;
using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
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
