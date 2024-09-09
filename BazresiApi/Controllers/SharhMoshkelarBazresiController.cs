using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharhMoshkelarBazresiController : ControllerBase
    {


        private readonly ISharhMoshkelatBazresi _sharhMoshkelatBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<SharhMoshkelarBazresiController> _logger;
        public SharhMoshkelarBazresiController(ISharhMoshkelatBazresi sharhMoshkelatBazresi, IMapper mapper, ILogger<SharhMoshkelarBazresiController> logger)
        {
            _logger = logger;
            _sharhMoshkelatBazresi = sharhMoshkelatBazresi;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var sharhMoshkelatBazresis = await _sharhMoshkelatBazresi.GetAsync(id);

                if (sharhMoshkelatBazresis == null || !sharhMoshkelatBazresis.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new SharhMoshkelatBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<SharhMoshkelatBazresiDto>>(sharhMoshkelatBazresis) }
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

        public async Task<ActionResult> Create(SharhMoshkelatBazresiDto sharhMoshkelatBazresi)
        {
            try
            {
                var SharhMoshkelatBazresi = _mapper.Map<T_Sharh_Moshkelat_Bazresi>(sharhMoshkelatBazresi);

                _sharhMoshkelatBazresi.add(SharhMoshkelatBazresi);
                await _sharhMoshkelatBazresi.SaveAsync();


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
