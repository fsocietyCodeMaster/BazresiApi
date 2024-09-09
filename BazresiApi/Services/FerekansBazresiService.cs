using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class FerekansBazresiService : IFerekansBazresi
    {
        private readonly BazresiDb _context;

        public FerekansBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Ferekans_Bazresi ferekansBazresi)
        {
            _context.FerekansBazresi.Add(ferekansBazresi);
            

        }

      

        public async Task<IEnumerable<T_L_Ferekans_Bazresi>> GetAsync(int id)
        {
            return await _context.FerekansBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
