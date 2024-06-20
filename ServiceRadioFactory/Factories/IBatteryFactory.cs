using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public interface IBatteryFactory
    {
        IBattery CreateBattery(string type);
    }

}
