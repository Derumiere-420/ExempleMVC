using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
{
    public interface IBatteryFactory<T> where T : IBattery
    {
        T CreateBattery();
    }

}
