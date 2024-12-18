using ToBlazor.Contracts.Contract;
using ToBlazor.Entities;

namespace ToBlazor.Data
{
    public class IdList<T> : List<T> where T : IId
    {
        private int idCount = 0;
        public new void Add(T item)
        {
            item.Id = idCount++;
            base.Add(item);
        }

    }
}
