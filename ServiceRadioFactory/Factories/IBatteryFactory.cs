using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Factories
{
    public interface IBatteryFactory
    {
        IBattery CreateBattery(string type);
    }

}
