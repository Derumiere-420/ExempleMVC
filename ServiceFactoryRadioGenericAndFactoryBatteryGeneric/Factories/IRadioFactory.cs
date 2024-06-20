using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public interface IRadioFactory<T> where T : IRadio
    {
        T CreateRadio(IBattery battery);
    }
}
