using LoveHeart.Domain;
using System.Collections.Generic;

namespace LoveHeart.Services
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
