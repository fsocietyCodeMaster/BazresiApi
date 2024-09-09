using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BarnameBazresiService : IBarnameBazresi
    {
        private readonly BazresiDb _context;

        public BarnameBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Barname_Bazresi barnameBazresi)
        {
            _context.BarnameBazresi.Add(barnameBazresi);
            

        }



        public async Task<IEnumerable<T_Barname_Bazresi>> GetAsync(int id)
        {
            return await _context.BarnameBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }



        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
