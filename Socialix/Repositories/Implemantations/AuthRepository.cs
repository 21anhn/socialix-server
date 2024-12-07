using Microsoft.AspNetCore.Identity;
using Socialix.Data;
using Socialix.Enums;
using Socialix.Models;
using Socialix.Repositories.Interfaces;
using Socialix.Utils;
using System.ComponentModel;

namespace Socialix.Repositories.Implemantations
{
    /// <summary>
    /// Auth Repository
    /// </summary>
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly AuthDbContext _authDbContext;
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationDbContext"></param>
        /// <param name="authDbContext"></param>
        public AuthRepository(ApplicationDbContext applicationDbContext, AuthDbContext authDbContext, UserManager<User> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _authDbContext = authDbContext;
            _userManager = userManager;
        }

        public async Task Regiter(User user, RoleEnum role)
        {
            var roleName = ConverterUtils.ConvertEnumToString(role);
            var identityRole = await _userManager.AddToRoleAsync(user, roleName);
            var identityUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                PhoneNumber = user.PhoneNumber, 
            };

            await _authDbContext.Users.AddAsync(identityUser);
            await _applicationDbContext.AddAsync(user);

            await _authDbContext.SaveChangesAsync();
            await _authDbContext.SaveChangesAsync();
        }
    }
}
