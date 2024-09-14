using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BazresAzmonService : IGenericRepository<T_Bazresi_Azmon>
    {
        private readonly BazresiDb _context;

        public BazresAzmonService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Bazresi_Azmon bazresiAzmon)
        {
            _context.BazresiAzmon.Add(bazresiAzmon);
            

        }



        public async Task<IEnumerable<T_Bazresi_Azmon>> GetAsync(long id)
        {
            return await _context.BazresiAzmon.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
