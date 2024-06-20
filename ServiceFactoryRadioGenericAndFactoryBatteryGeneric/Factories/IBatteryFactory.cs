using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public interface IBatteryFactory<T> where T : IBattery
    {
        T CreateBattery();
    }

}
