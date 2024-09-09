using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IBazresAzmonPic
    {
        Task<IEnumerable<T_Bazresi_Azmon_Pic>> GetAsync(int id);
        void add(T_Bazresi_Azmon_Pic bazresiAzmonPic);

        Task SaveAsync();
    }
}
