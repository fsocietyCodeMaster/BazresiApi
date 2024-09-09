using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BazresiCheckOkService : IBazresiCheckListOk
    {
        private readonly BazresiDb _context;

        public BazresiCheckOkService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Bazresi_CheckList_OK checkListOk)
        {
            _context.BazresiCheckList.Add(checkListOk);
        }




        public async Task<IEnumerable<T_Bazresi_CheckList_OK>> GetAsync(int id)
        {
            return await _context.BazresiCheckList.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
