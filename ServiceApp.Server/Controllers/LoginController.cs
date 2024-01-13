
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ServiceApp.Shared.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ServiceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginController(IConfiguration _configuration, SignInManager<IdentityUser> _signInManager)
        {
            this.configuration = _configuration;
            this.signInManager = _signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel _login)
        {
            var result = await this.signInManager.PasswordSignInAsync(_login.Email!, _login.Password!, false, false);
            if (!result.Succeeded)
            {
                return BadRequest(new LoginResult { Successful = false, Error = "username and password are invalid." });
            }

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, _login.Email!)
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JwtSecurityKey"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(this.configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken
                (
                    this.configuration["JwtIssuer"],
                    this.configuration["JwtAudience"],
                    claims,
                    expires: expiry,
                    signingCredentials: creds
                );
            return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

    } 
}
