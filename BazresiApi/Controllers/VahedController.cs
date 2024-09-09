using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VahedController : ControllerBase
    {

        private readonly IVahed _vahed;
        private readonly IMapper _mapper;
        private readonly ILogger<VahedController> _logger;

        public VahedController(IVahed vahed, IMapper mapper, ILogger<VahedController> logger)
        {

            _vahed = vahed;
            _mapper = mapper;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var Vahed = await _vahed.GetAsync(id);

                if (Vahed == null || !Vahed.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new VahedDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    Data = new { Response = _mapper.Map<IEnumerable<VahedDto>>(Vahed) }
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

        public async Task<ActionResult> Create(VahedDto vahed)
        {
            try
            {
                var Vahed = _mapper.Map<T_L_Vahed>(vahed);

                _vahed.add(Vahed);
                await _vahed.SaveAsync();


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
