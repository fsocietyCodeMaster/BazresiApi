using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaveshBazresiController : ControllerBase
    {

        private readonly IGenericRepository<RavesheBazresiDto> _raveshBazresi;
        private readonly ILogger<RaveshBazresiController> _logger;

        public RaveshBazresiController(IGenericRepository<RavesheBazresiDto> raveshBazresi, ILogger<RaveshBazresiController> logger)
        {
            _logger = logger;
            _raveshBazresi = raveshBazresi;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _raveshBazresi.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(RavesheBazresiDto ravesheBazresi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _raveshBazresi.AddAsync(ravesheBazresi);
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
