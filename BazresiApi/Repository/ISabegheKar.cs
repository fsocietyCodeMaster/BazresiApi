using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface ISabegheKar
    {
        Task<IEnumerable<T_L_SabegheKar>> GetAsync(int id);
        void add(T_L_SabegheKar sabegheKar);

        Task SaveAsync();
    }
}
