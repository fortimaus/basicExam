using Asp.DataBase.Enums;
using Asp.DataBase.Models;
using Asp.DataBase.Storages;
using Asp.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Asp.Controllers
{
    [Route("api/users/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserStorage storage = new UserStorage();
        [HttpGet("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string login, string password)
        {
            try
            {
                UserDto? res = storage.login(login, password);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                var claims = new List<Claim>
                    {
                    new Claim("Id",$"{res.Id}"),
                    new Claim(ClaimTypes.Role, $"{Enum.GetName(typeof(UserRole), res.role)}"),
                    };
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysupersecret_secretsecretsecretkey!123"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "MyAuthServer",
                    audience: "MyAuthClient",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new
                {
                    token = tokenString,
                    user = res
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserDto dto)
        {
            try
            {
                UserDto? res = storage.register(dto);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("delete/{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                UserDto? res = storage.delete(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("update")]
        [Authorize]
        public async Task<IActionResult> Update(UserDto dto)
        {
            try
            {
                UserDto? res = storage.update(dto);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                UserDto? res = storage.getById(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("page/{id}")]
        [Authorize]
        public async Task<IActionResult> GetByPage(int id)
        {
            try
            {
                List<UserDto>? res = storage.getPage(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("page_sort/{id}")]
        [Authorize]
        public async Task<IActionResult> GetByPageSort(int id)
        {
            try
            {
                List<UserDto>? res = storage.getSortByLogin(id);
                if (res == null)
                    return BadRequest("Произошла ошибка");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
