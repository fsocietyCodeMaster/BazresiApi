using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassItemController : ControllerBase
    {
        private readonly IClassItem _classItem;
        private readonly IMapper _mapper;
        private readonly ILogger<ClassItemController> _logger;

        public ClassItemController(BazresiDb context, IClassItem classItem, IMapper mapper, ILogger<ClassItemController> logger)
        {
            _logger = logger;
            _classItem = classItem;
            _mapper = mapper;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var ClassItem = await _classItem.GetAsync(id);

                if (ClassItem == null || !ClassItem.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new ClassItemDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<ClassItemDto>>(ClassItem) }
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

        public async Task<ActionResult> Create(ClassItemDto classItem)
        {
            try
            {
                var ClassItem = _mapper.Map<T_L_Class_Item>(classItem);

                _classItem.add(ClassItem);
                await _classItem.SaveAsync();


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
