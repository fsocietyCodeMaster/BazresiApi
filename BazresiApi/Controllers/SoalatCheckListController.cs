using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoalatCheckListController : ControllerBase
    {


        private readonly IGenericRepository<SoalatCheckListDto> _soalatCheckList;
        private readonly ILogger<SoalatCheckListController> _logger;
        public SoalatCheckListController(IGenericRepository<SoalatCheckListDto> soalatCheckList, ILogger<SoalatCheckListController> logger)
        {
            _logger = logger;
            _soalatCheckList = soalatCheckList;
        }



        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _soalatCheckList.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(SoalatCheckListDto SoalatCheckListDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _soalatCheckList.AddAsync(SoalatCheckListDto);
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
