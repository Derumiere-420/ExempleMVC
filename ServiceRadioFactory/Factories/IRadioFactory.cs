using ServiceRadioFactory.Services.Interfaces;

namespace ServiceRadioFactory.Factories
{
    public interface IRadioFactory
    {
        IRadio CreateRadio(string type, IBattery battery);
    }
}
