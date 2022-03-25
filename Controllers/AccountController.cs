using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebServicesAssignment4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : Controller
    {

        Login login = new Login();

        // POST
        [HttpPost, Route("")]
        public ActionResult Login(UserDTO userDTO)
        {
            return Ok(new LoginResult
            {
                UserName = userDTO.username,
                AccessToken = login.login(userDTO.username,userDTO.password)
                //RefreshToken = jwtResult.RefreshToken.TokenString
            });
        }

        /*
        [HttpPost("refresh-token")]
        [Authorize]
        public async Task<ActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            try
            {
                var userName = User.Identity?.Name;

                if (string.IsNullOrWhiteSpace(request.RefreshToken))
                {
                    return Unauthorized();
                }

                var accessToken = await HttpContext.GetTokenAsync("Bearer", "access_token");
                var jwtResult = _jwtAuthManager.Refresh(request.RefreshToken, accessToken, DateTime.Now);
                return Ok(new LoginResult
                {
                    UserName = userName,
                    Role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty,
                    AccessToken = jwtResult.AccessToken,
                    RefreshToken = jwtResult.RefreshToken.TokenString
                });
            }
            catch (SecurityTokenException e)
            {
                return Unauthorized(e.Message); // return 401 so that the client side can redirect the user to login page
            }
        }*/

    }

    public class LoginResult
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

    }

}
