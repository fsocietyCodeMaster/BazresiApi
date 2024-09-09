using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoalatCheckListController : ControllerBase
    {


        private readonly ISoalatCheckList _soalatCheckList;
        private readonly IMapper _mapper;
        private readonly ILogger<SoalatCheckListController> _logger;
        public SoalatCheckListController(ISoalatCheckList soalatCheckList, IMapper mapper, ILogger<SoalatCheckListController> logger)
        {
            _logger = logger;
            _soalatCheckList = soalatCheckList;
            _mapper = mapper;
        }



        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var SoalatCheckLists = await _soalatCheckList.GetAsync(id);

                if (SoalatCheckLists == null || !SoalatCheckLists.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new SoalatCheckListDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<SoalatCheckListDto>>(SoalatCheckLists) }
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

        public async Task<ActionResult> Create(SoalatCheckListDto soalatCheck)
        {
            try
            {
                var SoalatCheck = _mapper.Map<T_Soalat_CheckList>(soalatCheck);

                _soalatCheckList.add(SoalatCheck);
                await _soalatCheckList.SaveAsync();


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
