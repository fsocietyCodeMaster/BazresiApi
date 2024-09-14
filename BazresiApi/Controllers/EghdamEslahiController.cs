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
    public class EghdamEslahiController : ControllerBase
    {

        private readonly IGenericRepository<T_Eghdam_Eslahi> _eghdamEslahi;
        private readonly IMapper _mapper;
        private readonly ILogger<EghdamEslahiController> _logger;
        public EghdamEslahiController(IGenericRepository<T_Eghdam_Eslahi> eghdamEslahi, IMapper mapper, ILogger<EghdamEslahiController> logger)
        {
            _logger = logger;
            _eghdamEslahi = eghdamEslahi;
            _mapper = mapper;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var eghdamEslahis = await _eghdamEslahi.GetAsync(id);

                if (eghdamEslahis == null || !eghdamEslahis.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new EghdamEslahiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<EghdamEslahiDto>>(eghdamEslahis) }
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

        public async Task<ActionResult> Create(EghdamEslahiDto eghdam)
        {
            try
            {
                var EeghdamEslahi = _mapper.Map<T_Eghdam_Eslahi>(eghdam);

                _eghdamEslahi.add(EeghdamEslahi);
                await _eghdamEslahi.SaveAsync();


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
