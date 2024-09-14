using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class SharhMoshkelatBazresiService : IGenericRepository<T_Sharh_Moshkelat_Bazresi>
    {
        private readonly BazresiDb _context;

        public SharhMoshkelatBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Sharh_Moshkelat_Bazresi sharhMoshkelatBazresi)
        {
            _context.SharhMoshkelatBazresi.Add(sharhMoshkelatBazresi);
            

        }



 

        public async Task<IEnumerable<T_Sharh_Moshkelat_Bazresi>> GetAsync(long id)
        {
            return await _context.SharhMoshkelatBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
