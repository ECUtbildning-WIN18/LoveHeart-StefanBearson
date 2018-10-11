using LoveHeart.Domain;
using System.Collections.Generic;

namespace LoveHeart.Services
{
    interface ICustomerLoader
    {
        List<PetOwner> LoadUsers();
    }
}
