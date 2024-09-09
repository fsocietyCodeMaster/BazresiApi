using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBarnameBazresi
    {
        Task<IEnumerable<T_Barname_Bazresi>> GetAsync(int id);
        void add(T_Barname_Bazresi barnameBazresi);

        Task SaveAsync();
    }
}
