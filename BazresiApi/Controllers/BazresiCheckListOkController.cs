using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BazresiCheckListOkController : ControllerBase
    {

        private readonly IGenericRepository<BazresiCheckListOkDto> _bazresiCheckListOk;
        private readonly ILogger<BazresiCheckListOkController> _logger;
        public BazresiCheckListOkController(IGenericRepository<BazresiCheckListOkDto> bazresiCheckListOk, ILogger<BazresiCheckListOkController> logger)
        {
            _logger = logger;
            _bazresiCheckListOk = bazresiCheckListOk;

        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _bazresiCheckListOk.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(BazresiCheckListOkDto adminApp)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _bazresiCheckListOk.AddAsync(adminApp);
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
