using OrderProcessing.Application.Interfaces;
using OrderProcessing.Core.Entities;

namespace OrderProcessing.Infra.Repositories
{
    public class UserManagerServiceRepository : IUserManagerServiceRepository
    {
        public List<User?> userList;
        public UserManagerServiceRepository()
        {
            userList.Add(new User { UserId = 1, UserName = "admin", Password = "admin" }) ;
            userList.Add(new User { UserId = 2, UserName = "test", Password = "test" });
        }

        public User? GetUserById(int id)
        {
            var user = userList.FirstOrDefault(x=>x.UserId==id);
            return user;
        }
    }
}
