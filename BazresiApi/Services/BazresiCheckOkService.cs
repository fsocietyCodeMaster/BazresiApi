using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BazresiApi.Services
{
    public class BazresiCheckOkService : IGenericRepository<BazresiCheckListOkDto>
    {
        private readonly BazresiDb _context;
        private readonly IMapper _mapper;
        public BazresiCheckOkService(BazresiDb context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<ResponseDto> AddAsync(BazresiCheckListOkDto bazresiCheckOk)
        {
            if (bazresiCheckOk == null)
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
                var adminMapped = _mapper.Map<T_Bazresi_CheckList_OK>(bazresiCheckOk);
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
            var bazresiCheckOk = await _context.BazresiCheckList.Where(c => c.T_AdminsBackups_ID == id).ToListAsync();
            if (bazresiCheckOk.Any())
            {

                var success = new ResponseDto
                {
                    Message = "Books successfully retrieved .",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                    Data = new { response = _mapper.Map<IEnumerable<BazresiCheckListOkDto>>(bazresiCheckOk) }
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
