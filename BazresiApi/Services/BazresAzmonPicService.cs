using BazresiApi.Context;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Services
{
    public class BazresAzmonPicService : IBazresAzmonPic
    {
        private readonly BazresiDb _context;

        public BazresAzmonPicService(BazresiDb context)
        {
            _context = context;
        }
        public void add(T_Bazresi_Azmon_Pic bazresiAzmonPic)
        {
            _context.BazresiAzmonPic.Add(bazresiAzmonPic);
            

        }



        public async Task<IEnumerable<T_Bazresi_Azmon_Pic>> GetAsync(int id)
        {
            return await _context.BazresiAzmonPic.Where(u => u.T_AdminsBackups_ID == id).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
