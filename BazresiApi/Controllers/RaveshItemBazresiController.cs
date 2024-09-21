using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaveshItemBazresiController : ControllerBase
    {

        private readonly IGenericRepository<RaveshItemBazresiDto> _raveshItemBazresi;
        private readonly ILogger<RaveshItemBazresiController> _logger;

        public RaveshItemBazresiController(IGenericRepository<RaveshItemBazresiDto> raveshItem, ILogger<RaveshItemBazresiController> logger)
        {

            _raveshItemBazresi = raveshItem;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _raveshItemBazresi.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(RaveshItemBazresiDto raveshItemBazresi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _raveshItemBazresi.AddAsync(raveshItemBazresi);
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
