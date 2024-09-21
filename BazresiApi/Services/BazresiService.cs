using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BazresiApi.Services
{
    public class BazresiService : IGenericRepository<BazresiDto>
    {
        private readonly BazresiDb _context;
        private readonly IMapper _mapper;
        public BazresiService(BazresiDb context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ResponseDto> AddAsync(BazresiDto bazresi)
        {
            if (bazresi == null)
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
                var adminMapped = _mapper.Map<T_Bazres>(bazresi);
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
            var bazresi = await _context.Bazres.Where(c => c.T_AdminsBackups_ID == id).ToListAsync();
            if (bazresi.Any())
            {

                var success = new ResponseDto
                {
                    Message = "Books successfully retrieved .",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                    Data = new { response = _mapper.Map<IEnumerable<BazresiDto>>(bazresi) }
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

    }
}
