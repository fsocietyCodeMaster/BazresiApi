using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaziatEjraController : ControllerBase
    {

        private readonly IGenericRepository<VaziatEjraDto> _vaziat;
        private readonly ILogger<VaziatEjraController> _logger;
        public VaziatEjraController(IGenericRepository<VaziatEjraDto> vaziat, ILogger<VaziatEjraController> logger)
        {
            _logger = logger;
            _vaziat = vaziat;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _vaziat.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(VaziatEjraDto vaziatEjra)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _vaziat.AddAsync(vaziatEjra);
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
