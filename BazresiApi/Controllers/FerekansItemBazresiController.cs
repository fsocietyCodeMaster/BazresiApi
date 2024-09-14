using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerekansItemBazresiController : ControllerBase
    {


        private readonly IGenericRepository<T_Ferekans_Item_Bazresi> _ferekansItem;
        private readonly IMapper _mapper;
        private readonly ILogger<FerekansItemBazresiController> _logger;

        public FerekansItemBazresiController(IGenericRepository<T_Ferekans_Item_Bazresi> ferekansItemBazresi, IMapper mapper, ILogger<FerekansItemBazresiController> logger)
        {
            _logger = logger;
            _ferekansItem = ferekansItemBazresi;
            _mapper = mapper;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var FerekansItem = await _ferekansItem.GetAsync(id);

                if (FerekansItem == null || !FerekansItem.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new FerekansItemBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<FerekansItemBazresiDto>>(FerekansItem) }
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

        public async Task<ActionResult> Create(FerekansItemBazresiDto ferekansItem)
        {
            try
            {
                var FerekansBazresiItem = _mapper.Map<T_Ferekans_Item_Bazresi>(ferekansItem);

                _ferekansItem.add(FerekansBazresiItem);
                await _ferekansItem.SaveAsync();


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
