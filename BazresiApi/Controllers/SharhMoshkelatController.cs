using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharhMoshkelatController : ControllerBase
    {

        private readonly ISharhMoshkelat _sharhMoshkelat;
        private readonly IMapper _mapper;
        private readonly ILogger<SharhMoshkelatController> _logger;
        public SharhMoshkelatController(ISharhMoshkelat sharhMoshkelat, IMapper mapper, ILogger<SharhMoshkelatController> logger)
        {
            _logger = logger;
            _sharhMoshkelat = sharhMoshkelat;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var SharhMoshkelats = await _sharhMoshkelat.GetAsync(id);

                if (SharhMoshkelats == null || !SharhMoshkelats.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new SharhMoshkelatDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<SharhMoshkelatDto>>(SharhMoshkelats) }
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

        public async Task<ActionResult> Create(SharhMoshkelatDto sharhMoshkelat)
        {
            try
            {
                var SharhMoshkelat = _mapper.Map<T_L_Sharh_Moshkelat>(sharhMoshkelat);

                _sharhMoshkelat.add(SharhMoshkelat);
                await _sharhMoshkelat.SaveAsync();


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
