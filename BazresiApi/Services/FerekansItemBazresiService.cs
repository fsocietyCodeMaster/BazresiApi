using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class FerekansItemBazresiService : IFerekansItemBazresi
    {
        private readonly BazresiDb _context;

        public FerekansItemBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Ferekans_Item_Bazresi ferekansItemBazresi)
        {
            _context.FerekansItem.Add(ferekansItemBazresi);
            

        }


  

        public async Task<IEnumerable<T_Ferekans_Item_Bazresi>> GetAsync(int id)
        {
            return await _context.FerekansItem.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
