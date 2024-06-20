using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Battery
{
    public class Battery : IBattery
    {
        public virtual string PowerOff()
        {
            return $"{this.GetType().Name} Battery is powering Off.";
        }

        public virtual string PowerOn()
        {
            return $"{this.GetType().Name} Battery is powering On.";
        }
    }
}
