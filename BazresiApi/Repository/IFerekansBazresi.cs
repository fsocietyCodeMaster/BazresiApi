using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IFerekansBazresi
    {
        Task<IEnumerable<T_L_Ferekans_Bazresi>> GetAsync(int id);
        void add(T_L_Ferekans_Bazresi ferekansBazresi);

        Task SaveAsync();
    }
}
