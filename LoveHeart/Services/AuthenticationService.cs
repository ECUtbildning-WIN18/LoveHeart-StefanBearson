using LoveHeart.Domain;
using System.Linq;

namespace LoveHeart.Services
{
    class AuthenticationService : IAuthenticationService
    {
        private readonly IUserLoader _userLoader;

        public AuthenticationService()
        {
            _userLoader = new UserLoader();
        }

        public User Authenticate(string username, string password)
        {
            var users = _userLoader.LoadUsers();

            return users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}
