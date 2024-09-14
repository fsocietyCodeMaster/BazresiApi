using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class AdminService : IGenericRepository<T_AdminApp>
    {
        private readonly BazresiDb _context;

        public AdminService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_AdminApp admin)
        {
            _context.admin.Add(admin);
            

        }



        public async Task<IEnumerable<T_AdminApp>> GetAsync(long id)
        {
            return await _context.admin.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }



        public async Task SaveAsync()
        {
             await _context.SaveChangesAsync();
        }
    }
}
