using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaveshBazresiController : ControllerBase
    {

        private readonly IGenericRepository<T_L_Ravesh_Bazresi> _raveshBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<RaveshBazresiController> _logger;

        public RaveshBazresiController(IGenericRepository<T_L_Ravesh_Bazresi> raveshBazresi, IMapper mapper, ILogger<RaveshBazresiController> logger)
        {
            _logger = logger;
            _raveshBazresi = raveshBazresi;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var RaveshBazrsi = await _raveshBazresi.GetAsync(id);

                if (RaveshBazrsi == null || !RaveshBazrsi.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new RavesheBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<RavesheBazresiDto>>(RaveshBazrsi) }
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false,
                };

                return BadRequest(error);
            }
        }
        #endregion





        #region Post

        [HttpPost]

        public async Task<ActionResult> Create(RavesheBazresiDto ravesheBazresi)
        {
            try
            {
                var RaveshBazresi = _mapper.Map<T_L_Ravesh_Bazresi>(ravesheBazresi);

                _raveshBazresi.add(RaveshBazresi);
                await _raveshBazresi.SaveAsync();


                var success = new ResponsePostDto
                {
                    Message = "successfully added.",
                    IsSuccess = true
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false,
                };

                return BadRequest(error);
            }
        }
        #endregion
    }
}
