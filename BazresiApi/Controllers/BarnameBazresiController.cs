using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BarnameBazresiController : ControllerBase
    {

        private readonly IGenericRepository<BarnameBazresiDto> _barnameBazresi;
        private readonly ILogger<BarnameBazresiController> _logger;

        public BarnameBazresiController(IGenericRepository<BarnameBazresiDto> barnameBazresi, ILogger<BarnameBazresiController> logger)
        {
            _logger = logger;
            _barnameBazresi = barnameBazresi;
        }



        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _barnameBazresi.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(BarnameBazresiDto barnameBazresi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _barnameBazresi.AddAsync(barnameBazresi);
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
