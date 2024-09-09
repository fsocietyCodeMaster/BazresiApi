using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class SharhMoshkelatService : ISharhMoshkelat
    {
        private readonly BazresiDb _context;

        public SharhMoshkelatService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Sharh_Moshkelat sharhMoshkelat)
        {
            _context.SharhMoshkelat.Add(sharhMoshkelat);
           

        }



        public async Task<IEnumerable<T_L_Sharh_Moshkelat>> GetAsync(int id)
        {
            return await _context.SharhMoshkelat.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
