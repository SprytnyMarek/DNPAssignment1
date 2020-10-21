using DNPAssignment.Data;
using Models;

namespace DNPAssignment.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}