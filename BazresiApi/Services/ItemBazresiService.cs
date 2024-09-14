using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class ItemBazresiService : IGenericRepository<T_Item_Bazresi>
    {
        private readonly BazresiDb _context;

        public ItemBazresiService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Item_Bazresi itemBazresi)
        {
            _context.ItemBazresi.Add(itemBazresi);
            

        }


        public async Task<IEnumerable<T_Item_Bazresi>> GetAsync(long id)
        {
            return await _context.ItemBazresi.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
