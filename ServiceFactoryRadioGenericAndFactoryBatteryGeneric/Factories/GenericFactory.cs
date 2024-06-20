namespace ServiceFactoryRadioGenericAndFactoryBatteryGeneric.Factories
{
    public class GenericFactory : IGenericFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public GenericFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public T Create<T>() where T : notnull
        {
            return _serviceProvider.GetRequiredService<T>();
        }

        public T Create<T>(params object[] parameters) where T : notnull
        {
            return (T)ActivatorUtilities.CreateInstance(_serviceProvider, typeof(T), parameters);
        }

        
    }

}
