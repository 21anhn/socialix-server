using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Socialix.Models;

namespace Socialix.Data
{
    public class AuthDbContext : IdentityDbContext<User>
    {
    }
}
