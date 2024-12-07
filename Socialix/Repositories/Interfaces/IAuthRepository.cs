using Socialix.Enums;
using Socialix.Models;

namespace Socialix.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task Regiter(User user, RoleEnum role);
    }
}
