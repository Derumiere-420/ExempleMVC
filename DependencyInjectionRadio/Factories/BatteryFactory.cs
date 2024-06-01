using ExempleDependencyInjectionRadio.Services.Implementations;
using ExempleDependencyInjectionRadio.Services.Interfaces;

namespace ExempleDependencyInjectionRadio.Factories
{
    public class BatteryFactory : IBatteryFactory
    {
        private readonly IServiceProvider _serviceProvider;
       
        public BatteryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
           
        }

        public IBattery CreateBattery(string type)
        {
            IBattery battery = type switch
            {
                "Lithium" => _serviceProvider.GetRequiredService<LithiumBattery>(),
                "NickelCadmium" => _serviceProvider.GetRequiredService<NickelCadmiumBattery>(),
                "Alkaline" => _serviceProvider.GetRequiredService<AlkalineBattery>(),
                _ => _serviceProvider.GetRequiredService<LithiumBattery>(),
            };

            return battery;
        }

    }

}
