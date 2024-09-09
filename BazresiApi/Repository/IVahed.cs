using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IVahed
    {
        Task<IEnumerable<T_L_Vahed>> GetAsync(int id);
        void add(T_L_Vahed vahed);

        Task SaveAsync();
    }
}
