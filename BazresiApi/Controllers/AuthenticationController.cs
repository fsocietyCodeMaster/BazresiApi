using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUser _user;
        private readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(IUser user, ILogger<AuthenticationController> logger)
        {
            _user = user;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _user.RegisterAsync(register);
                    if (result.isSuccess)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest(result);
                    }
                }
                else
                {
                    return BadRequest("some properties are not valid ");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred.");

                var error = new ResponseDto
                {
                    Message = "Error.",
                    IsSuccess = false,
                };

                return BadRequest(error);
            }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var result = await _user.LoginAsync(login);

                    if (result.isSuccess)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest(result);
                    }


                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "an error occurred.");

                    var error = new ResponseDto
                    {
                        Message = "Error.",
                        IsSuccess = false,
                    };

                    return BadRequest(error);
                }


            }
            else
            {
                return BadRequest("some properties are not valid ");
            }

        }
    }
}
