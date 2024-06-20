using ServiceBatteryAndRadioFactory.Services.Implementations.Battery;
using ServiceBatteryAndRadioFactory.Services.Implementations.Radio;
using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public class RadioFactory<T> : IRadioFactory<T> where T : IRadio
    {
        private readonly IServiceProvider _serviceProvider;

        public RadioFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }
        public T CreateRadio(IBattery battery)
        {
            return _serviceProvider.GetRequiredService<T>();
        }


    }
}
