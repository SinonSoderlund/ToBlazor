using ToBlazor.Contracts.Request;

namespace ToBlazor.Contracts.Services
{
    public interface IDataService<T>
    {
        Task<IRequest<IEnumerable<T>>> GetAllAsync();
        Task<IRequest<T>> GetAsync(IRequest<T> GetRequets);
        Task<IRequest<T>> UpdateAsync(IRequest<T> UpdateRequets);
        Task<IRequest<T>> DeleteAsync(IRequest<T> DeleteRequets);
        Task<IRequest<T>> CreateAsync(IRequest<T> CreateRequets);
    }
}
