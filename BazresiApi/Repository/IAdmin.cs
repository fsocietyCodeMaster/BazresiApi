using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IAdmin
    { 
        Task<IEnumerable<T_AdminApp>> GetAsync(int id);
        void add(T_AdminApp admin);

        Task SaveAsync();
    }
}
