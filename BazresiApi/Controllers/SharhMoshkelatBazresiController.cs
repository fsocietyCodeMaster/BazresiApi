using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharhMoshkelatBazresiController : ControllerBase
    {


        private readonly IGenericRepository<SharhMoshkelatBazresiDto> _sharhMoshkelatBazresi;
        private readonly ILogger<SharhMoshkelatBazresiController> _logger;
        public SharhMoshkelatBazresiController(IGenericRepository<SharhMoshkelatBazresiDto> sharhMoshkelatBazresi, ILogger<SharhMoshkelatBazresiController> logger)
        {
            _logger = logger;
            _sharhMoshkelatBazresi = sharhMoshkelatBazresi;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _sharhMoshkelatBazresi.GetAsync(id);
                if (result.IsSuccess == true)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "an error occurred.");

                var error = new ResponseDto
                {
                    Message = "Error.",
                    IsSuccess = false,
                    Status = StatusCodes.Status404NotFound.ToString()
                };

                return BadRequest(error);
            }

        }
        #endregion





        #region Post

        [HttpPost]

        public async Task<ActionResult<ResponseDto>> Create(SharhMoshkelatBazresiDto sharhMoshkelatBazresi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _sharhMoshkelatBazresi.AddAsync(sharhMoshkelatBazresi);
                    if (result.IsSuccess == true)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest(result);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "an error occurred.");

                    var error = new ResponseDto
                    {
                        Message = "Error.",
                        IsSuccess = false,
                        Status = StatusCodes.Status404NotFound.ToString()
                    };

                    return BadRequest(error);
                }

            }

            return BadRequest("Some parameters not valid.");
        }
        #endregion
    }
}
