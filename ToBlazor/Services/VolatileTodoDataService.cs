using ToBlazor.Contracts.Repositories;
using ToBlazor.Contracts.Request;
using ToBlazor.Contracts.Services;
using ToBlazor.Entities;

namespace ToBlazor.Services
{
    public class VolatileTodoDataService : IDataService<Todo>
    {
        private readonly IDataRepository<Todo> repository;
        public VolatileTodoDataService(IDataRepository<Todo> _repository)
        {
            repository = _repository;
        }
        public async Task<IRequest<Todo>> CreateAsync(IRequest<Todo> CreateRequets)
        {
            return await repository.CreateAsync(CreateRequets);
        }

        public async Task<IRequest<Todo>> DeleteAsync(IRequest<Todo> DeleteRequets)
        {
            return await repository.DeleteAsync(DeleteRequets);
        }

        public async Task<IRequest<IEnumerable<Todo>>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<IRequest<Todo>> GetAsync(IRequest<Todo> GetRequets)
        {
            return await repository.GetAsync(GetRequets);
        }

        public Task<IRequest<Todo>> UpdateAsync(IRequest<Todo> UpdateRequets)
        {
            throw new NotImplementedException();
        }
    }
}
