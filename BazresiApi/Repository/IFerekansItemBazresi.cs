using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IFerekansItemBazresi
    {
        Task<IEnumerable<T_Ferekans_Item_Bazresi>> GetAsync(int id);
        void add(T_Ferekans_Item_Bazresi ferekansItemBazresi);

        Task SaveAsync();
    }
}
