using ServiceBatteryAndRadioFactory.Services.Interfaces;

namespace ServiceBatteryAndRadioFactory.Services.Implementations.Battery
{
    public class AlkalineBattery : Battery
    {
        public int Energy { get; set; }

        public AlkalineBattery()
        {
            Energy = 100;
        }
        public override string PowerOff()
        {
            return $"{this.GetType().Name} Battery is at {Energy} and powering on .";
        }

        public override string PowerOn()
        {
            return $"{this.GetType().Name} Battery is at {Energy} powering Off.";
        }
    }

}
