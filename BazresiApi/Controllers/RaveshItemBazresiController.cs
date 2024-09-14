using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaveshItemBazresiController : ControllerBase
    {

        private readonly IGenericRepository<T_Ravesh_Item_Bazresi> _raveshItemBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<RaveshItemBazresiController> _logger;

        public RaveshItemBazresiController(IGenericRepository<T_Ravesh_Item_Bazresi> raveshItem, IMapper mapper, ILogger<RaveshItemBazresiController> logger)
        {

            _raveshItemBazresi = raveshItem;
            _mapper = mapper;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var RaveshBazrsiItem = await _raveshItemBazresi.GetAsync(id);

                if (RaveshBazrsiItem == null || !RaveshBazrsiItem.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new RaveshItemBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<RaveshItemBazresiDto>>(RaveshBazrsiItem) }
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

        public async Task<ActionResult> Create(RaveshItemBazresiDto raveshItem)
        {
            try
            {
                var RaveshBazresiItem = _mapper.Map<T_Ravesh_Item_Bazresi>(raveshItem);

                _raveshItemBazresi.add(RaveshBazresiItem);
                await _raveshItemBazresi.SaveAsync();


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
