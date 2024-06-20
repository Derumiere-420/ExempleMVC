using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Radio
{
    public class Samsung : Radio
    {
        public Samsung() : base()
        {
            RadioName = this.GetType().Name;
        }
    }
}
