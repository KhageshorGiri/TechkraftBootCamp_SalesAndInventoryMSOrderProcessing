using OrderProcessing.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Application.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly IAuthenticationRepository _authRepository;
        public AuthenticationService(IAuthenticationRepository _repository)
        {
            this._authRepository = _repository;
        }

        public Task LoginUserAsync()
        {
            _authRepository.LoginUserAsync();
            return null;
        }
    }
}
