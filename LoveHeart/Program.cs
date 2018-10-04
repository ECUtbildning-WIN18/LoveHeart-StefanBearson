using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Domain;
using LoveHeart.Views;


namespace LoveHeart
{
    class Program
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        public static Dictionary<string, PetOwner> customers = new Dictionary<string, PetOwner>();
        public static List<Vet> vets = new List<Vet>();

        static void Main(string[] args)
        {
            UserInitDB.AddUsers();
            PetOwnerInitDB.AddPetOwners();
            PetInitDB.addingPetsToOwners();
            
            VetInitDB.AddVets();
            AppointmentInitDB.add();
            LogIn.View();
        }
    }
}
