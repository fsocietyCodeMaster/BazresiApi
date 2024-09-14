using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BazresiAzmonController : ControllerBase
    {

        private readonly IGenericRepository<T_Bazresi_Azmon> _bazresAzmon;
        private readonly IMapper _mapper;
        private readonly ILogger<BazresiAzmonController> _logger;

        public BazresiAzmonController(IGenericRepository<T_Bazresi_Azmon> bazresAzmon, IMapper mapper, ILogger<BazresiAzmonController> logger)
        {
            _logger = logger;
            _bazresAzmon = bazresAzmon;
            _mapper = mapper;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var BazresiAzmon = await _bazresAzmon.GetAsync(id);

                if (BazresiAzmon == null || !BazresiAzmon.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new BazresiAzmonDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<BazresiAzmonDto>>(BazresiAzmon) }
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred.");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false
                };

                return BadRequest(error);
            }
        }
        #endregion



        #region Post

        [HttpPost]

        public async Task<ActionResult> Create(BazresiAzmonDto bazresiAzmon)
        {

            try
            {
                var BazrasAzmon = _mapper.Map<T_Bazresi_Azmon>(bazresiAzmon);

                _bazresAzmon.add(BazrasAzmon);
                await _bazresAzmon.SaveAsync();


                var success = new ResponsePostDto
                {
                    Message = "successfully added.",
                    IsSuccess = true
                };

                return Ok(success);  
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred.");

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
