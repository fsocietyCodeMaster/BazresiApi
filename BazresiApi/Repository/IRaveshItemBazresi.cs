using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IRaveshItemBazresi
    {
        Task<IEnumerable<T_Ravesh_Item_Bazresi>> GetAsync(int id);
        void add(T_Ravesh_Item_Bazresi raveshItemBazresi);

        Task SaveAsync();
    }
}
