using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Domain;

namespace LoveHeart.Views
{
    class RecRegisterPetView
    {
        public static void PetRegView(PetOwner petowner)
        {
            Console.Clear();
            HeaderView.Header();
            Console.WriteLine();
            //petowner.OwnerAnimals.Add(new Pet("test", "test", DateTime.MinValue));
            Console.WriteLine("Adding a pet");
            Console.WriteLine();
            Console.WriteLine($"Owner: {petowner.FirstName} {petowner.LastName}");
            Console.WriteLine("Pet information");
            Console.WriteLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Nickname:");
            string nickname = Console.ReadLine();
            Console.WriteLine("Type of animal:");
            string typeOfAnimal = Console.ReadLine();
            Console.WriteLine("Date of birth (yyyy-mm-dd):");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Is this correct? (Y)es (N)o");
            char correct = Console.ReadKey().KeyChar;
            if (correct == 'y' || correct == 'Y')
            {
                petowner.OwnerAnimals.Add(new Pet(name,nickname, typeOfAnimal, birthdate));
                RecMenu.menuView();
            }
            else
            {
                PetRegView(petowner);
            }



                Console.ReadKey();
        }
    }
}
