using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class VahedService : IGenericRepository<T_L_Vahed>
    {
        private readonly BazresiDb _context;

        public VahedService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Vahed vahed)
        {
            _context.Vahed.Add(vahed);


        }



        public async Task<IEnumerable<T_L_Vahed>> GetAsync(long id)
        {
            return await _context.Vahed.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
