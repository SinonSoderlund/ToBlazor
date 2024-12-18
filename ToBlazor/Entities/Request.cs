using ToBlazor.Contracts.Request;

namespace ToBlazor.Entities
{
    public class Request<T> : IRequest<T>
    {
        public T Data { get; set; }

        public Request(T data = default!)
        {
            Data = data;
        }
    }
}
