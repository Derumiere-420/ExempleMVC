using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Factories
{
    public interface IBatteryFactory
    {
        IBattery CreateBattery(string type);
    }

}
