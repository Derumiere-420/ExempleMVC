using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
{
    public interface IBatteryFactory
    {
        IBattery CreateBattery(string type);
    }

}
