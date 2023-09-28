using Microsoft.IdentityModel.Tokens;
using OrderProcessing.Application.Interfaces;
using OrderProcessing.Infra.ContextClass;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Infra.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly OrderProcessingContext dbContext;

        public AuthenticationRepository(OrderProcessingContext _Context)
        {
            this.dbContext = _Context;
        }

        public Task LoginUserAsync()
        {
            var user = "ram";//await _userManagementService.GetUserByEmailAsync(tokenRequest);
            if (user != null)
            {
                return null;
                //return CreateJwtToke(user);
            }
            throw new AuthenticationException();
        }

        // function to create a JWT token
        private string CreateJwtToke()
        {
            var claimsList = new List<Claim>
                {
                    //new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
                    //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

                    //new Claim(ClaimTypes.Name, user.UserName),
                    //new Claim(ClaimTypes.Email, user.Email)
                };


            var SecretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisisSecretXKeyThaGeneratETheJWTTokenishdgihsuihiwhj"));
            var creds = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
            (
                issuer: "",
                audience: "",
                claims: claimsList,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: creds
            );

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            /*var tokenResponse = new TokenResponse()
            {
                Token = jwtToken,
                RefreshToken = ""
            };*/

            return "hello";
        }
    }
}
