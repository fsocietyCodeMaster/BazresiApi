using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class ClassItemService : IGenericRepository<T_L_Class_Item>
    {
        private readonly BazresiDb _context;

        public ClassItemService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_L_Class_Item classItem)
        {
            _context.ClassItem.Add(classItem);
            

        }



        public async Task<IEnumerable<T_L_Class_Item>> GetAsync(long id)
        {
            return await _context.ClassItem.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
