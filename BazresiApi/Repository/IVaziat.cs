using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IVaziat
    {
        Task<IEnumerable<T_L_Vaziat_Ejra>> GetAsync(int id);
        void add(T_L_Vaziat_Ejra vaziatEjra);

        Task SaveAsync();
    }
}
