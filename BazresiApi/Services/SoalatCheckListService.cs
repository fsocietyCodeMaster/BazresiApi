using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class SoalatCheckListService : IGenericRepository<T_Soalat_CheckList>
    {
        private readonly BazresiDb _context;

        public SoalatCheckListService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Soalat_CheckList soalatCheckList)
        {
            _context.SoalatCheckList.Add(soalatCheckList);
            

        }



        public async Task<IEnumerable<T_Soalat_CheckList>> GetAsync(long id)
        {
            return await _context.SoalatCheckList.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
