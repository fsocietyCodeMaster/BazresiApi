using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBazresVahed
    {
        Task<IEnumerable<T_Bazres_Vahed>> GetAsync(int id);
        void add(T_Bazres_Vahed bazresVahed);

        Task SaveAsync();
    }
}
