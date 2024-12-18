namespace ToBlazor.Contracts.Data
{
    public interface IDataStore<T>
    {
        T DataStore { get; }
    }
}
