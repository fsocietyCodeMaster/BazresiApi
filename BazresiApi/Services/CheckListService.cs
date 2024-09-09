using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class CheckListService : ICheckList
    {
        private readonly BazresiDb _context;

        public CheckListService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_CheckList checkList)
        {
            _context.CheckList.Add(checkList);
            

        }

 

        public async Task<IEnumerable<T_CheckList>> GetAsync(int id)
        {
            return await _context.CheckList.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
