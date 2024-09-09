using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IItemBazresi
    {
        Task<IEnumerable<T_Item_Bazresi>> GetAsync(int id);
        void add(T_Item_Bazresi itemBazresi);

        Task SaveAsync();
    }
}
