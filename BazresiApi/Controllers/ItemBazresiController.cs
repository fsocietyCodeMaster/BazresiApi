using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemBazresiController : ControllerBase
    {

        private readonly IItemBazresi _itemBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<ItemBazresiController> _logger;
        public ItemBazresiController(IItemBazresi itemBazresi, IMapper mapper, ILogger<ItemBazresiController> logger)
        {
            _logger = logger;
            _itemBazresi = itemBazresi;
            _mapper = mapper;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var ItemBazresi = await _itemBazresi.GetAsync(id);

                if (ItemBazresi == null || !ItemBazresi.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new ItemBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<ItemBazresiDto>>(ItemBazresi) }
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

        public async Task<ActionResult> Create(ItemBazresiDto itemBazresi)
        {
            try
            {
                var ItemBazresi = _mapper.Map<T_Item_Bazresi>(itemBazresi);

                _itemBazresi.add(ItemBazresi);
                await _itemBazresi.SaveAsync();


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
