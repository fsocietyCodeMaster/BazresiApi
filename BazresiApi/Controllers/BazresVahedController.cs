using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BazresVahedController : ControllerBase
    {



        private readonly IGenericRepository<T_Bazres_Vahed> _bazresVahed;
        private readonly IMapper _mapper;
        private readonly ILogger<BazresVahedController> _logger;
        public BazresVahedController(IGenericRepository<T_Bazres_Vahed> bazresVahed, IMapper mapper, ILogger<BazresVahedController> logger)
        {
            _logger = logger;
            _bazresVahed = bazresVahed;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var BazresiVahed = await _bazresVahed.GetAsync(id);

                if (BazresiVahed == null || !BazresiVahed.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess= false,
                        Data = new BazresiVahedDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<BazresiVahedDto>>(BazresiVahed) }
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

        public async Task<ActionResult> Create(BazresiVahedDto bazresiVahed)
        {
            try
            {
                var BazresiVahed = _mapper.Map<T_Bazres_Vahed>(bazresiVahed);

                _bazresVahed.add(BazresiVahed);
                await _bazresVahed.SaveAsync();


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
