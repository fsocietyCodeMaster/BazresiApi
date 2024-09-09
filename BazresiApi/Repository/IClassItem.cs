using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IClassItem
    {
        Task<IEnumerable<T_L_Class_Item>> GetAsync(int id);
        void add(T_L_Class_Item classItem);

        Task SaveAsync();
    }
}
