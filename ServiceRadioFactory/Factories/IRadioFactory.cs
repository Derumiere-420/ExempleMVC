using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public interface IRadioFactory<T> where T : IBattery
    {
        T CreateRadio(IBattery battery);
    }
}
