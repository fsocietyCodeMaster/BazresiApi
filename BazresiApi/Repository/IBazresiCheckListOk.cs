using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBazresiCheckListOk
    {
        Task<IEnumerable<T_Bazresi_CheckList_OK>> GetAsync(int id);
        void add(T_Bazresi_CheckList_OK checkListOk);

        Task SaveAsync();
    }
}
