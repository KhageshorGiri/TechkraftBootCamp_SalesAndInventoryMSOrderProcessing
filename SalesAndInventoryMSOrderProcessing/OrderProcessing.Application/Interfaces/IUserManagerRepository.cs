using OrderProcessing.Core.Entities;

namespace OrderProcessing.Application.Interfaces
{
    public interface IUserManagerServiceRepository
    {
        User? GetUserById(int id);
    }
}
