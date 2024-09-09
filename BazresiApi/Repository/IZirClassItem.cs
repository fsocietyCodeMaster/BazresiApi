using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IZirClassItem
    {
        Task<IEnumerable<T_L_Zir_Class_Item>> GetAsync(int id);
        void add(T_L_Zir_Class_Item zirClassItem);

        Task SaveAsync();
    }
}
