using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBazres
    {
        Task<IEnumerable<T_Bazres>> GetAsync(int id);
        void add(T_Bazres bazres);

        Task SaveAsync();
    }
}
