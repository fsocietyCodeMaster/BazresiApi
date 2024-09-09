using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class VaziatService : IVaziat
    {
        private readonly BazresiDb _context;

        public VaziatService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Vaziat_Ejra vaziatEjra)
        {
            _context.VaziatEjra.Add(vaziatEjra);
            

        }




        public async Task<IEnumerable<T_L_Vaziat_Ejra>> GetAsync(int id)
        {
            return await _context.VaziatEjra.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
