using ServiceBatteryFactory.Services.Interfaces;

namespace ServiceBatteryFactory.Services.Implementations
{
    public class AlkalineBattery : Battery
    {
        public int Power { get; set; }
        
        public override string PowerOn()
        {
           return(base.PowerOn() + $" Power at {this.Power}");
        }

        public override string PowerOff()
        {
            return (base.PowerOn() + $" Power at {this.Power}");
        }
    }

}
