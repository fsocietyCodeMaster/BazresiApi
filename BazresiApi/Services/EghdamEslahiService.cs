using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class EghdamEslahiService : IGenericRepository<T_Eghdam_Eslahi>
    {
        private readonly BazresiDb _context;

        public EghdamEslahiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Eghdam_Eslahi eghdamEslahi)
        {
            _context.EghdamEslahi.Add(eghdamEslahi);
            

        }



        public async Task<IEnumerable<T_Eghdam_Eslahi>> GetAsync(long id)
        {
            return await _context.EghdamEslahi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
