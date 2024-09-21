using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckListController : ControllerBase
    {


        private readonly IGenericRepository<CheckListDto> _checkList;
        private readonly IMapper _mapper;
        private readonly ILogger<CheckListController> _logger;
        public CheckListController(IGenericRepository<CheckListDto> checkList, ILogger<CheckListController> logger)
        {
            _logger = logger;
            _checkList = checkList;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            try
            {


                var result = await _checkList.GetAsync(id);
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

        public async Task<ActionResult<ResponseDto>> Create(CheckListDto checkList)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _checkList.AddAsync(checkList);
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


