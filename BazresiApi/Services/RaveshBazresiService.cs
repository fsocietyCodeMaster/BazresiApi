using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BazresiApi.Services
{
    public class RaveshBazresiService : IGenericRepository<RavesheBazresiDto>
    {
        private readonly BazresiDb _context;
        private readonly IMapper _mapper;
        public RaveshBazresiService(BazresiDb context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto> AddAsync(RavesheBazresiDto ravesheBazresi)
        {
            if (ravesheBazresi == null)
            {
                var error = new ResponseDto
                {
                    Message = "Something is wrong.",
                    IsSuccess = false,
                    Status = HttpStatusCode.BadRequest.ToString(),
                };
                return error;
            }
            else
            {
                var adminMapped = _mapper.Map<T_L_Ravesh_Bazresi>(ravesheBazresi);
                _context.Add(adminMapped);
                await _context.SaveChangesAsync();

                var success = new ResponseDto
                {
                    Message = "successfully added.",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                };
                return success;
            }


        }



        public async Task<ResponseDto> GetAsync(long id)
        {
            var ravesheBazresi = await _context.RaveshBazresi.Where(c => c.T_AdminsBackups_ID == id).ToListAsync();
            if (ravesheBazresi.Any())
            {

                var success = new ResponseDto
                {
                    Message = "Books successfully retrieved .",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                    Data = new { response = _mapper.Map<IEnumerable<RavesheBazresiDto>>(ravesheBazresi) }
                };
                return success;
            }
            else
            {
                var error = new ResponseDto
                {
                    Message = "Nothing found.",
                    IsSuccess = false,
                    Status = HttpStatusCode.NotFound.ToString(),
                };
                return error;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
