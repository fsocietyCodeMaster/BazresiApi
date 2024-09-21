using BazresiApi.DTO;

namespace BazresiApi.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ResponseDto> GetAsync(long id);
        Task<ResponseDto> AddAsync(T entity);
    }
}
