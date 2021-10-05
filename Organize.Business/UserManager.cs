using Organize.Shared.Contracts;
using Organize.Shared.Enitites;
using System.Threading.Tasks;
using System;

namespace Organize.Business
{
    public class UserManager: IUserManager
    {
        public async Task<User> TrySignInAndGetUserAsync(User user)
        {
            Console.WriteLine("Hi from UserManager");
            return  await Task.FromResult(new User());
        }

        public async Task InsertUserAsync(User user)
        {
            await Task.FromResult(true);
        }
    }
}
