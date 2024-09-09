using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class SabegheKarService : ISabegheKar
    {
        private readonly BazresiDb _context;

        public SabegheKarService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_SabegheKar sabegheKar)
        {
            _context.SabegheKar.Add(sabegheKar);
            

        }



 

        public async Task<IEnumerable<T_L_SabegheKar>> GetAsync(int id)
        {
            return await _context.SabegheKar.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
