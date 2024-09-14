using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SabegheKarController : ControllerBase
    {


        private readonly IGenericRepository<T_L_SabegheKar> _sabegheKar;
        private readonly IMapper _mapper;
        private readonly ILogger<SabegheKarController> _logger;

        public SabegheKarController(IGenericRepository<T_L_SabegheKar> sabegheKar, IMapper mapper, ILogger<SabegheKarController> logger)
        {

            _sabegheKar = sabegheKar;
            _mapper = mapper;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var sabegheKars = await _sabegheKar.GetAsync(id);

                if (sabegheKars == null || !sabegheKars.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new SabegheKarDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<SabegheKarDto>>(sabegheKars) }
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

        public async Task<ActionResult> Create(SabegheKarDto sabegheKar)
        {
            try
            {
                var SabegheKar = _mapper.Map<T_L_SabegheKar>(sabegheKar);

                _sabegheKar.add(SabegheKar);
                await _sabegheKar.SaveAsync();


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
                    Success = false
                };

                return BadRequest(error);
            }
        }
        #endregion
    }
}
