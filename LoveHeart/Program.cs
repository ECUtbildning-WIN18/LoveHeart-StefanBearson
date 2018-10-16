using LoveHeart.Domain;
using LoveHeart.Services;
using LoveHeart.Views;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;


namespace LoveHeart
{
    class Program
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        public static Dictionary<string, PetOwner> customers = new Dictionary<string, PetOwner>();
        public static List<Vet> vets = new List<Vet>();

        public static SpeechSynthesizer synth = new SpeechSynthesizer();
        public static bool speak = false;

        static void Main(string[] args)
        {
            Console.Title = "Love Heart";
            PetOwnerInitDB.AddPetOwners();
            PetInitDB.addingPetsToOwners();
            VetInitDB.AddVets();
            AppointmentInitDB.add();

            LogIn.View();
        }

        //test method, delete at release
        public static void PrintCustomerList()
        {
            CustomerAndPetLoader customerLoader = new CustomerAndPetLoader();
            var customers = customerLoader.LoadUsers();

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} : {customer.SocialSecurityNumber}");
                customer.OwnerAnimals.ForEach(pet => Console.WriteLine($"{pet.Name} is a {pet.TypeOfAnimal}"));
            }

            Console.ReadKey();
            RecMenu.MenuView();
        }
    }
}
