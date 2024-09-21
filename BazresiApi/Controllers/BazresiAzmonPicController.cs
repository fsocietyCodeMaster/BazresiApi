using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BazresiAzmonPicController : ControllerBase
    {

        private readonly IGenericRepository<BazresiAzmonPicDto> _bazresAzmonPic;
        private readonly ILogger<BazresiAzmonPicController> _logger;

        public BazresiAzmonPicController(IGenericRepository<BazresiAzmonPicDto> bazresAzmonPic, ILogger<BazresiAzmonPicController> logger)
        {
            _logger = logger;
            _bazresAzmonPic = bazresAzmonPic;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {
                var result = await _bazresAzmonPic.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(BazresiAzmonPicDto bazresiAzmonPic)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _bazresAzmonPic.AddAsync(bazresiAzmonPic);
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
