using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharhMoshkelatController : ControllerBase
    {

        private readonly IGenericRepository<SharhMoshkelatDto> _sharhMoshkelat;
        private readonly ILogger<SharhMoshkelatController> _logger;
        public SharhMoshkelatController(IGenericRepository<SharhMoshkelatDto> sharhMoshkelat, ILogger<SharhMoshkelatController> logger)
        {
            _logger = logger;
            _sharhMoshkelat = sharhMoshkelat;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _sharhMoshkelat.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(SharhMoshkelatDto sharhMoshkelat)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _sharhMoshkelat.AddAsync(sharhMoshkelat);
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
