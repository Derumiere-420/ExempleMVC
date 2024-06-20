using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Radio
{
    public class LG : Radio
    {
        
        public LG() : base()
        {
            RadioName = this.GetType().Name;
        }
    }
}
