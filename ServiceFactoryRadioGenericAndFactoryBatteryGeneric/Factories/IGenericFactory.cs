namespace ServiceFactoryRadioGenericAndFactoryBatteryGeneric.Factories
{
    public interface IGenericFactory
    {
        T Create<T>() where T : notnull;
        T Create<T>(params object[] parameters) where T : notnull;
    }
}
