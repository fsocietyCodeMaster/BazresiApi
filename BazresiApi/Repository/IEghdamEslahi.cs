using BazresiApi.Models;

namespace BazresiApi.Repository
{
    public interface IEghdamEslahi
    {
        Task<IEnumerable<T_Eghdam_Eslahi>> GetAsync(int id);
        void add(T_Eghdam_Eslahi eghdamEslahi);

        Task SaveAsync();
    }
}
