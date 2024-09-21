using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VahedController : ControllerBase
    {

        private readonly IGenericRepository<VahedDto> _vahed;
        private readonly ILogger<VahedController> _logger;

        public VahedController(IGenericRepository<VahedDto> vahed, ILogger<VahedController> logger)
        {

            _vahed = vahed;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _vahed.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(VahedDto vahed)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _vahed.AddAsync(vahed);
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
