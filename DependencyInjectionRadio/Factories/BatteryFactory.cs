using ServiceBatteryFactory.Services.Implementations;
using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
{
    public class BatteryFactory<T> : IBatteryFactory<T> where T : IBattery
    {
        private readonly IServiceProvider _serviceProvider;

        public BatteryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }

        public T CreateBattery()
        {
            return _serviceProvider.GetRequiredService<T>();
        }

    }

}
