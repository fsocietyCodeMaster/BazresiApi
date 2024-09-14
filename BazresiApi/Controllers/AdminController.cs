using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BazresiApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IGenericRepository<T_AdminApp> _admin;
        private readonly IMapper _mapper;
        private readonly ILogger<AdminController> _logger;
        public AdminController(IGenericRepository<T_AdminApp> admin, IMapper mapper, ILogger<AdminController> logger)
        {
            _logger = logger;
            _admin = admin;
            _mapper = mapper;
        }

        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var users = await _admin.GetAsync(id);

                if (users == null || !users.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found.",
                        IsSuccess = false,
                        Data = new AdminAppDto { }

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<AdminAppDto>>(users) }
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

        public async Task<ActionResult> Create(AdminAppDto adminApp)
        {
            try
            {
                var admin = _mapper.Map<T_AdminApp>(adminApp);

                _admin.add(admin);
                await _admin.SaveAsync();


                var success = new ResponsePostDto
                {
                    Message = "successfully added.",
                    IsSuccess = true
                };

                return Ok(success);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred.");

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
