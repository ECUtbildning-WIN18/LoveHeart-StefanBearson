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
            //Testar();

            PetOwnerInitDB.AddPetOwners();
            PetInitDB.addingPetsToOwners();
            VetInitDB.AddVets();
            AppointmentInitDB.add();

            LogIn.View();
        }

        public static void Testar()
        {
            CustomerAndPetLoader customerLoader = new CustomerAndPetLoader();
            var customers = customerLoader.LoadUsers();

            foreach (var customer in customers)
            {
                CustomerSaver.Save(customer);
                CustomerSaver.customerlist.Save("CustomersTemp.xml");
                }
            Console.ReadKey();
        }
    }
}
