using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Radio
{
    public class Sony : Radio
    {
        public Sony() : base()
        {
            RadioName = this.GetType().Name;
        }
    }
}
