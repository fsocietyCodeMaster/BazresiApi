using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class RaveshItemBazresiService : IRaveshItemBazresi
    {
        private readonly BazresiDb _context;

        public RaveshItemBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Ravesh_Item_Bazresi raveshItemBazresi)
        {
            _context.RaveshItemBazresi.Add(raveshItemBazresi);
            

        }


   

        public async Task<IEnumerable<T_Ravesh_Item_Bazresi>> GetAsync(int id)
        {
            return await _context.RaveshItemBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
