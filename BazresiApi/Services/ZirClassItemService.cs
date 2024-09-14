using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class ZirClassItemService : IGenericRepository<T_L_Zir_Class_Item>
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

   

        public async Task<IEnumerable<T_L_Zir_Class_Item>> GetAsync(long id)
        {
            return await _context.ZirClassItem.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
