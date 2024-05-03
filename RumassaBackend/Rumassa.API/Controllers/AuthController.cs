using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.AuthService;
using Rumassa.Domain.Entities.Auth;
using Rumassa.Domain.Entities.DTOs;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly IAuthService _authService;

        public AuthController(UserManager<User> userManager, IAuthService authService)
        {
            _userManager = userManager;
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO register)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }

            var user = new User()
            {
                UserName = register.Name + register.Surname,
                Name = register.Name,
                Surname = register.Surname,
                Email = register.Email,
                Password = register.Password,
                PhoneNumber = register.PhoneNumber,
                Role = "User"
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (!result.Succeeded)
                throw new Exception();

            await _userManager.AddToRoleAsync(user, "User");

            return Ok(new ResponseModel()
            {
                IsSuccess = true,
                Message = "Successfully created",
                StatusCode = 201
            });

        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception();
            }
            var user = await _userManager.FindByEmailAsync(login.Email);

            if (user == null)
            {
                return BadRequest(new TokenDTO()
                {
                    Message = "Email Not Found!",
                    isSuccess = false,
                    Token = ""
                });
            }

            var checker = await _userManager.CheckPasswordAsync(user, login.Password);
            if (!checker)
            {
                return BadRequest(new TokenDTO()
                {
                    Message = "Password do not match!",
                    isSuccess = false,
                    Token = ""
                });
            }

            var token = _authService.GenerateToken(user);

            return Ok(new TokenDTO()
            {
                Token = token,
                isSuccess = true,
                Message = "Success"
            });

        }

    }
}
