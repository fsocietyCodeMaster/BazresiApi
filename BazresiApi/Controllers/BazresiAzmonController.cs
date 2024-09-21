using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BazresiAzmonController : ControllerBase
    {

        private readonly IGenericRepository<BazresiAzmonDto> _bazresAzmon;
        private readonly ILogger<BazresiAzmonController> _logger;

        public BazresiAzmonController(IGenericRepository<BazresiAzmonDto> bazresAzmon, ILogger<BazresiAzmonController> logger)
        {
            _logger = logger;
            _bazresAzmon = bazresAzmon;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _bazresAzmon.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(BazresiAzmonDto bazresiAzmon)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _bazresAzmon.AddAsync(bazresiAzmon);
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
