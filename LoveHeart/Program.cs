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
        public static bool speak = false;
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
    }
}
