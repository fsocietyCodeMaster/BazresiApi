using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaziatEjraController : ControllerBase
    {

        private readonly IGenericRepository<T_L_Vaziat_Ejra> _vaziat;
        private readonly IMapper _mapper;
        private readonly ILogger<VaziatEjraController> _logger;
        public VaziatEjraController(IGenericRepository<T_L_Vaziat_Ejra> vaziat, IMapper mapper, ILogger<VaziatEjraController> logger)
        {
            _logger = logger;
            _vaziat = vaziat;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var Vaziat = await _vaziat.GetAsync(id);

                if (Vaziat == null || !Vaziat.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new VaziatEjraDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    Data = new { Response = _mapper.Map<IEnumerable<VaziatEjraDto>>(Vaziat) }
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

        public async Task<ActionResult> Create(VaziatEjraDto vaziatEjra)
        {
            try
            {
                var Vaziat = _mapper.Map<T_L_Vaziat_Ejra>(vaziatEjra);

                _vaziat.add(Vaziat);
                await _vaziat.SaveAsync();


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
