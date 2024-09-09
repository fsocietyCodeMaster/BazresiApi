using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface ICheckList
    {
        Task<IEnumerable<T_CheckList>> GetAsync(int id);
        void add(T_CheckList checkListOk);

        Task SaveAsync();
    }
}
