using BazresiApi.Context;
using BazresiApi.Customized;
using BazresiApi.DTO;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BazresiApi.Services
{
    public class UserService : IUser
    {
        private readonly BazresiDb _db;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserService(BazresiDb db, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }


        public async Task<UserManageResponse> RegisterAsync(RegisterDto register)
        {

            if (register.Password != register.PasswordConfirmed)
            {
                return new UserManageResponse()
                {
                    Message = "Password doesn't match.",
                    isSuccess = false

                };
            }

            var identityUser = new CustomUser()
            {
                UserName = register.UserName,
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                PhoneNumber = register.PhoneNumber,
                Address = register.Address
            };

            var result = await _userManager.CreateAsync(identityUser, register.Password);

            if (!result.Succeeded)
            {
                return new UserManageResponse()
                {
                    Message = "there is a problem while creating the user.",
                    isSuccess = false,
                    Error = result.Errors.Select(e => e.Description)
                };
            }
            else
            {
                if (register.Roles != null && register.Roles.Any())
                {
                    foreach (var role in register.Roles)
                    {
                        if (!await _roleManager.RoleExistsAsync(role))
                        {
                            var userRole = new IdentityRole()
                            {
                                Name = role
                            };
                            await _roleManager.CreateAsync(userRole);
                        }
                        await _userManager.AddToRoleAsync(identityUser, role);
                    }
                }

                return new UserManageResponse()
                {
                    Message = "User is created successfully.",
                    isSuccess = true
                };
            }

        }



        public async Task<UserManageResponse> LoginAsync(LoginDto login)
        {
            var userExist = await _userManager.FindByEmailAsync(login.Email);

            if (userExist == null)
            {
                return new UserManageResponse()
                {
                    Message = "There is no user with this email address.",
                    isSuccess = false
                };
            }

            var result = await _userManager.CheckPasswordAsync(userExist, login.Password);

            if (!result)
            {
                return new UserManageResponse()
                {
                    Message = "invalid credential",
                    isSuccess = false
                };
            }

            var userRole = await _userManager.GetRolesAsync(userExist);

            var SecreteKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signingKey = new SigningCredentials(SecreteKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier,userExist.Id),
                new(ClaimTypes.Name, userExist.FirstName)
            };

            if(userRole != null)
            {
                foreach (var role in userRole)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));   
                }
            }

            var jwtConfig = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingKey

                );


            var token = new JwtSecurityTokenHandler().WriteToken(jwtConfig);
            return new UserManageResponse()
            {
                Message = token,
                isSuccess = true
            };
        }


    }
}


