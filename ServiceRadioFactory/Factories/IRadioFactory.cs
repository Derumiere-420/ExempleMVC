using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Factories
{
    public interface IRadioFactory
    {
        IRadio CreateRadio(string type, IBattery battery);
    }
}
