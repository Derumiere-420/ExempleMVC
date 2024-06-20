using ServiceBatteryFactory.Services.Implementations.Battery;
using ServiceBatteryFactory.Services.Implementations.Radio;
using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
{
    public class RadioFactory : IRadioFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public RadioFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }
        public IRadio CreateRadio(string type, IBattery battery)
        {
            IRadio radio;
            switch (type)
            {
                case "Sony":
                    radio = _serviceProvider.GetRequiredService<Sony>();
                    radio._battery = battery;
                    break;
                case "Samsung":
                    radio = _serviceProvider.GetRequiredService<Samsung>();
                    radio._battery = battery;
                    break;
                case "LG":
                    radio = _serviceProvider.GetRequiredService<LG>();
                    radio._battery = battery;
                    break;
                default:
                    radio = _serviceProvider.GetRequiredService<Sony>();
                    radio._battery = battery;
                    break;
            }

            return radio;
        }

       
    }
}
