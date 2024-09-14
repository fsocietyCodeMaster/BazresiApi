using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckListController : ControllerBase
    {


        private readonly IGenericRepository<T_CheckList> _checkList;
        private readonly IMapper _mapper;
        private readonly ILogger<CheckListController> _logger;
        public CheckListController(IGenericRepository<T_CheckList> checkList, IMapper mapper, ILogger<CheckListController> logger)
        {
            _logger = logger;
            _checkList = checkList;
            _mapper = mapper;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var CheckList = await _checkList.GetAsync(id);

                if (CheckList == null || !CheckList.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new CheckListDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<CheckListDto>>(CheckList) }
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false,
                };

                return BadRequest(error);
            }
        }
        #endregion


  


        #region Post

        [HttpPost]

        public async Task<ActionResult> Create(CheckListDto checkList)
        {
            try
            {
                var CheckList = _mapper.Map<T_CheckList>(checkList);

                _checkList.add(CheckList);
                await _checkList.SaveAsync();


                var success = new ResponsePostDto
                {
                    Message = "successfully added.",
                    IsSuccess = true
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false,
                };

                return BadRequest(error);
            }
        }
        #endregion
    }
}


