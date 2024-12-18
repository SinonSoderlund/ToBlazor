using ToBlazor.Contracts.Data;
using ToBlazor.Contracts.Repositories;
using ToBlazor.Contracts.Request;
using ToBlazor.Data;
using ToBlazor.Entities;

namespace ToBlazor.Repositories
{
    #pragma warning disable CS1998
    public class VolatileTodoDataRepository : IDataRepository<Todo>
    {
        private readonly IdList<Todo> todoList;
        public VolatileTodoDataRepository(IDataStore<IdList<Todo>> todoStore)
        {
            todoList = todoStore.DataStore;
        }

        public async Task<IRequest<Todo>> CreateAsync(IRequest<Todo> CreateRequets)
        {
            todoList.Add(CreateRequets.Data);
            return CreateRequets;
        }

        public async Task<IRequest<Todo>> DeleteAsync(IRequest<Todo> DeleteRequets)
        {
            todoList.Remove(DeleteRequets.Data);
            return DeleteRequets;
        }

        public async Task<IRequest<IEnumerable<Todo>>> GetAllAsync()
        {
            return new Request<IEnumerable<Todo>>(todoList);
        }

        public async Task<IRequest<Todo>> GetAsync(IRequest<Todo> GetRequets)
        {
            GetRequets.Data = todoList.FirstOrDefault(t => t.Id == GetRequets.Data.Id)!;
            return GetRequets;
        }

        public async Task<IRequest<Todo>> UpdateAsync(IRequest<Todo> UpdateRequets)
        {
            throw new NotImplementedException();
        }
    }
}
