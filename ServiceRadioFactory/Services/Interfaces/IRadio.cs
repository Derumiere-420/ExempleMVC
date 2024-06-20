namespace ServiceBatteryFactory.Services.Interfaces
{
    public interface IRadio
    {
        IBattery _battery { get; set; }
        bool IsRadioOn { get; set; }
        string RadioName { get; set; }
        String TurnOn();
        String TurnOff();
        String BatteryType();
        Boolean GetRadioStatus();
       
    }
}
