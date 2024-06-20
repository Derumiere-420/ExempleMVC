using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations.Battery
{
    public class Battery : IBattery
    {
        public virtual string PowerOff()
        {
            return $"{this.GetType().Name} Battery is powering on.";
        }

        public virtual string PowerOn()
        {
            return $"{this.GetType().Name} Battery is powering Off.";
        }
    }
}
