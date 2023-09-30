using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Application.Interfaces;

namespace OrderProcessing.Presentation.Controllers
{
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthentication _authenticationService;
        public AuthenticationController(IAuthentication authentication)
        {
            this._authenticationService = authentication;
        }

        // POST: /api/token
        [AllowAnonymous]
        [HttpPost]
        [Route("api/token")]
        public async Task<ActionResult> LoginUserAsync()
        {
            // check if the user exist in db or not
            var tokenResponse = "";//await _authenticationService.LoginUserAsync();
            return Ok(tokenResponse);
        }

    }
}
