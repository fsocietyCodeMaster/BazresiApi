using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBazresAzmon
    {
        Task<IEnumerable<T_Bazresi_Azmon>> GetAsync(int id);
        void add(T_Bazresi_Azmon bazresiAzmon);

        Task SaveAsync();
    }
}
