using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BazresService : IBazres
    {
        private readonly BazresiDb _context;

        public BazresService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Bazres bazres)
        {
            _context.Bazres.Add(bazres);
            

        }



        public async Task<IEnumerable<T_Bazres>> GetAsync(int id)
        {
            return await _context.Bazres.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
