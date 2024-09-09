using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BarnameBazresiController : ControllerBase
    {

        private readonly IBarnameBazresi _barnameBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<BarnameBazresiController> _logger;

        public BarnameBazresiController(IBarnameBazresi barnameBazresi, IMapper mapper, ILogger<BarnameBazresiController> logger)
        {
            _logger = logger;
            _barnameBazresi = barnameBazresi;
            _mapper = mapper;
        }



        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var Barname = await _barnameBazresi.GetAsync(id);

                if (Barname == null || !Barname.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new BarnameBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<BarnameBazresiDto>>(Barname) }
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




        #region Post

        [HttpPost]

        public async Task<ActionResult> Create(BarnameBazresiDto barnameBazresi)
        {
            try
            {
                var BarnameBazresi = _mapper.Map<T_Barname_Bazresi>(barnameBazresi);

                _barnameBazresi.add(BarnameBazresi);
                await _barnameBazresi.SaveAsync();

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
