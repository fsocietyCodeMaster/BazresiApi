using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class RaveshBazresiService : IGenericRepository<T_L_Ravesh_Bazresi>
    {
        private readonly BazresiDb _context;

        public RaveshBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Ravesh_Bazresi raveshBazresi)
        {
            _context.RaveshBazresi.Add(raveshBazresi);
           

        }




        public async Task<IEnumerable<T_L_Ravesh_Bazresi>> GetAsync(long id)
        {
            return await _context.RaveshBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
