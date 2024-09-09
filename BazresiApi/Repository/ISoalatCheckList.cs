using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface ISoalatCheckList
    {
        Task<IEnumerable<T_Soalat_CheckList>> GetAsync(int id);
        void add(T_Soalat_CheckList soalatCheckList);

        Task SaveAsync();
    }
}
