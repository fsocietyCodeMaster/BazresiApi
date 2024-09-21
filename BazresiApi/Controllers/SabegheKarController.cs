using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SabegheKarController : ControllerBase
    {


        private readonly IGenericRepository<SabegheKarDto> _sabegheKar;
        private readonly ILogger<SabegheKarController> _logger;

        public SabegheKarController(IGenericRepository<SabegheKarDto> sabegheKar, ILogger<SabegheKarController> logger)
        {

            _sabegheKar = sabegheKar;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _sabegheKar.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(SabegheKarDto sabegheKar)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _sabegheKar.AddAsync(sabegheKar);
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
