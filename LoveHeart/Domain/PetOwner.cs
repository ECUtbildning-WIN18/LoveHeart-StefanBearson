using System.Collections.Generic;

namespace LoveHeart.Domain
{
    class PetOwner
    {
        public List<Pet> OwnerAnimals = new List<Pet>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        public PetOwner(string firstName, string lastName, string socialSecurityNumber, List<Pet> ownerAnimals)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            OwnerAnimals = ownerAnimals;
        }

        public PetOwner(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
