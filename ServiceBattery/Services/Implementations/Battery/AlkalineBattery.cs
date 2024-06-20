using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations.Battery
{
    public class AlkalineBattery : Battery
    {
        public int Power { get; set; }

        public AlkalineBattery()
        {
            Power = 100;
        }
        public override string PowerOn()
        {
            return ($"{base.PowerOn()} power at {Power}");
        }

        public override string PowerOff()
        {
            return ($"{base.PowerOff()} power at {Power}");
        }
    }

}
