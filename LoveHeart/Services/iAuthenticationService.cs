using LoveHeart.Domain;

namespace LoveHeart.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
