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
    public class FerekansBazresiController : ControllerBase
    {

        private readonly IGenericRepository<T_L_Ferekans_Bazresi> _ferekansBazresi;
        private readonly IMapper _mapper;
        private readonly ILogger<FerekansBazresiController> _logger;

        public FerekansBazresiController(IGenericRepository<T_L_Ferekans_Bazresi> ferekansBazresi, IMapper mapper, ILogger<FerekansBazresiController> logger)
        {
            _logger = logger;
            _ferekansBazresi = ferekansBazresi;
            _mapper = mapper;
            _logger = logger;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var ferekansBazresis = await _ferekansBazresi.GetAsync(id);

                if (ferekansBazresis == null || !ferekansBazresis.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new FerekansBazresiDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<FerekansBazresiDto>>(ferekansBazresis) }
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

        public async Task<ActionResult> Create(FerekansBazresiDto ferekans)
        {
            try
            {
                var FerekansBazresi = _mapper.Map<T_L_Ferekans_Bazresi>(ferekans);

                _ferekansBazresi.add(FerekansBazresi);
                await _ferekansBazresi.SaveAsync();


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
