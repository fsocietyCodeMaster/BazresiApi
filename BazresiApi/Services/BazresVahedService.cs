using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BazresVahedService : IGenericRepository<T_Bazres_Vahed>
    {
        private readonly BazresiDb _context;

        public BazresVahedService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Bazres_Vahed BazresVahed)
        {
            _context.BazresVahed.Add(BazresVahed);
           

        }



        public async Task<IEnumerable<T_Bazres_Vahed>> GetAsync(long id)
        {
            return await _context.BazresVahed.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
