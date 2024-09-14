using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BazresiCheckListOkController : ControllerBase
    {

        private readonly IGenericRepository<T_Bazresi_CheckList_OK> _bazresiCheckListOk;
        private readonly IMapper _mapper;
        private readonly ILogger<BazresiCheckListOkController> _logger;
        public BazresiCheckListOkController(IGenericRepository<T_Bazresi_CheckList_OK> bazresiCheckListOk, IMapper mapper, ILogger<BazresiCheckListOkController> logger)
        {
            _logger = logger;
            _bazresiCheckListOk = bazresiCheckListOk;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var BazresiCheck = await _bazresiCheckListOk.GetAsync(id);

                if (BazresiCheck == null || !BazresiCheck.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new BazresiCheckListOkDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<BazresiCheckListOkDto>>(BazresiCheck) }
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

        public async Task<ActionResult> Create(BazresiCheckListOkDto bazresiCheckList)
        {
            try
            {
                var BazCheckList = _mapper.Map<T_Bazresi_CheckList_OK>(bazresiCheckList);

                _bazresiCheckListOk.add(BazCheckList);
                await _bazresiCheckListOk.SaveAsync();


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
