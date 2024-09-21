using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerekansItemBazresiController : ControllerBase
    {


        private readonly IGenericRepository<FerekansItemBazresiDto> _ferekansItem;
        private readonly ILogger<FerekansItemBazresiController> _logger;

        public FerekansItemBazresiController(IGenericRepository<FerekansItemBazresiDto> ferekansItemBazresi, ILogger<FerekansItemBazresiController> logger)
        {
            _logger = logger;
            _ferekansItem = ferekansItemBazresi;
        }
        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {
                var result = await _ferekansItem.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(FerekansItemBazresiDto ferekansItemBazresi)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _ferekansItem.AddAsync(ferekansItemBazresi);
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
