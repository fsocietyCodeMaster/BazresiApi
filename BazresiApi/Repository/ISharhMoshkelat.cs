using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface ISharhMoshkelat
    {
        Task<IEnumerable<T_L_Sharh_Moshkelat>> GetAsync(int id);
        void add(T_L_Sharh_Moshkelat sharhMoshkelat);

        Task SaveAsync();
    }
}
