using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZirClassItemController : ControllerBase
    {


        private readonly IZirClassItem _zirClassItem;
        private readonly IMapper _mapper;
        private readonly ILogger<ZirClassItemController> _logger;
        public ZirClassItemController(IZirClassItem zirClassItem, IMapper mapper, ILogger<ZirClassItemController> logger)
        {
            _logger = logger;
            _zirClassItem = zirClassItem;
            _mapper = mapper;
        }



        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var ZirClassItem = await _zirClassItem.GetAsync(id);

                if (ZirClassItem == null || !ZirClassItem.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new ZirClassItemDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<ZirClassItemDto>>(ZirClassItem) }
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

        public async Task<ActionResult> CreateZirClass(ZirClassItemDto zirClass)
        {
            try
            {
                var ZirClass = _mapper.Map<T_L_Zir_Class_Item>(zirClass);

                _zirClassItem.add(ZirClass);
                await _zirClassItem.SaveAsync();


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
