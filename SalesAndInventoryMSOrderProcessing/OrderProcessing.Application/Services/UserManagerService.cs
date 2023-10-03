using OrderProcessing.Core.Entities;

namespace OrderProcessing.Application.Interfaces
{
    public class UserManagerService : IUserManagerService
    {
        private readonly IUserManagerServiceRepository userRepository;
        public UserManagerService(IUserManagerServiceRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }
        public User? GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
