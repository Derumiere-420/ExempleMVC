using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Factories
{
    public interface IRadioFactory
    {
        IRadio CreateRadio(string type, IBattery battery);
    }
}
