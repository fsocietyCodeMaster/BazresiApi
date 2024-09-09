using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface ISharhMoshkelatBazresi
    {
        Task<IEnumerable<T_Sharh_Moshkelat_Bazresi>> GetAsync(int id);
        void add(T_Sharh_Moshkelat_Bazresi sharhMoshkelatBazresi);

        Task SaveAsync();
    }
}
