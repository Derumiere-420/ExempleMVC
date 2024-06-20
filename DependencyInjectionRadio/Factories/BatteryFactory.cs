using ServiceBatteryAndRadioFactory.Services.Implementations;
using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
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
