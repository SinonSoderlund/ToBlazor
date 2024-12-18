using ToBlazor.Contracts.Data;
using ToBlazor.Entities;

namespace ToBlazor.Data
{
    public class VolatileTodoDataStore : IDataStore<IdList<Todo>>
    {
        public IdList<Todo> DataStore { get; }

        public VolatileTodoDataStore()
        {
            DataStore = new IdList<Todo>();
        }


    }
}
