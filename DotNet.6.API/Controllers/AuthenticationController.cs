using DotNet._6.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DotNet._6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        IConfiguration configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(AuthenticationRequestBody authenticationRequestBody)
        {
            var user = ValidateUser(authenticationRequestBody);
            if (user == null)
            {
                return Unauthorized();
            }

            //Symmetric key to generate SigningCredentials
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:SecretForKey"]));

            //SigningCredentials to sign JWT token to confirm that the sender of the token is who it says it is and to ensure that the message wasn't changed in transit.
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            // Claims for the token
            var claimsForToken = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserId),
                new Claim(ClaimTypes.GivenName, user.Firstname),
                new Claim(ClaimTypes.Surname, user.Lastname),
                new Claim(ClaimTypes.Locality, user.City)
            };

            // Create the JWT security token and encode it.
            var token = new JwtSecurityToken(
                issuer: configuration["Authentication:Issuer"],
                audience: configuration["Authentication:Audience"],
                claims: claimsForToken,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);


            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

        private User ValidateUser(AuthenticationRequestBody authenticationRequestBody)
        {
            //This is just a sample. In real world, you will be validating against a database or some other store.
            return new User() { Firstname = "Pradip", Lastname = "Desai", UserId = "pdesai", City = "Pune" };
        }
    }
}
