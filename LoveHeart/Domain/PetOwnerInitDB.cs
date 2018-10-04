using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class PetOwnerInitDB
    {
        public static void AddPetOwners()
        {
            PetOwner po1 = new PetOwner("Pelle", "Jönsson", "470101-1234");
            PetOwner po2 = new PetOwner("Göran", "Ahara", "990101-5123");
            PetOwner po3 = new PetOwner("Nils", "Smith", "800101-1264");
            PetOwner po4 = new PetOwner("Sofia", "Pjudor", "220101-6532");
            PetOwner po5 = new PetOwner("Sara", "Lalala", "360101-1464");

            Program.customers.Add(po1.SocialSecurityNumber, po1);
            Program.customers.Add(po2.SocialSecurityNumber, po2);
            Program.customers.Add(po3.SocialSecurityNumber, po3);
            Program.customers.Add(po4.SocialSecurityNumber, po4);
            Program.customers.Add(po5.SocialSecurityNumber, po5);
        }
        

        

    }
}
