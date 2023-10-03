using OrderProcessing.Core.Entities;

namespace OrderProcessing.Application.Interfaces
{
    public interface IUserManagerService
    {
        User? GetUserById(int id);
    }
}
