using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LoveHeart.Actions;
using LoveHeart.Domain;
using LoveHeart.Views;


namespace LoveHeart
{
    class Program
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        public static Dictionary<string, PetOwner> customers = new Dictionary<string, PetOwner>();
        public static List<Vet> vets = new List<Vet>();
        public static bool speak = true;
        public static SpeechSynthesizer synth = new SpeechSynthesizer();
        static void Main(string[] args)
        {

            UserInitDB.AddUsers();
            PetOwnerInitDB.AddPetOwners();
            PetInitDB.addingPetsToOwners();
            VetInitDB.AddVets();
            AppointmentInitDB.add();
            
            LogIn.View();
        }

        public static void TestarLinq()
        {
            
            var customer = customers.Where(a => a.Key == "470101-1234");
            var keyValuePairs = customer as KeyValuePair<string, PetOwner>[] ?? customer.ToArray();
            Console.WriteLine(customer.GetEnumerator().Current.Value.FirstName);
            var test = customer.GetEnumerator().Current.Value.OwnerAnimals;
            
            foreach (var pet in test)
            {
                Console.WriteLine(pet.Name);
            }
            foreach (var pet in keyValuePairs)
            {
                foreach (var animal in pet.Value.OwnerAnimals)
                {
                    Console.WriteLine(animal.Name);
                }
            }

            foreach (var animal in keyValuePairs)
            {
                Console.WriteLine(animal.Value.OwnerAnimals[0].Name);
                Console.WriteLine(animal.Value.OwnerAnimals[1].Name);
            }

            Console.ReadKey();

        }
    }
}
