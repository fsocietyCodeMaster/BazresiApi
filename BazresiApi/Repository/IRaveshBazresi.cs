using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IRaveshBazresi
    {
        Task<IEnumerable<T_L_Ravesh_Bazresi>> GetAsync(int id);
        void add(T_L_Ravesh_Bazresi raveshBazresi);

        Task SaveAsync();
    }
}
