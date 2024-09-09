using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class ZirClassItemService : IZirClassItem
    {
        private readonly BazresiDb _context;

        public ZirClassItemService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Zir_Class_Item zirClassItem)
        {
            _context.ZirClassItem.Add(zirClassItem);
            

        }

   

        public async Task<IEnumerable<T_L_Zir_Class_Item>> GetAsync(int id)
        {
            return await _context.ZirClassItem.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
