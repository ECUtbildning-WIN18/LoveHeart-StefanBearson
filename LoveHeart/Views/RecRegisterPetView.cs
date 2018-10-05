using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Actions;
using LoveHeart.Domain;

namespace LoveHeart.Views
{
    class RecRegisterPetView
    {
        public static void PetRegView(PetOwner petowner)
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.WriteLine("Adding a pet");
            Console.WriteLine();
            Console.Write($"Owner: {petowner.FirstName} {petowner.LastName}");
            Console.WriteLine("Pet information");
            Console.WriteLine();
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Nickname:");
            string nickname = Console.ReadLine();
            Console.Write("Type of animal:");
            string typeOfAnimal = Console.ReadLine();
            Console.WriteLine("Date of birth (yyyy-mm-dd):");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Tools.IsThisCorrectText();
            char correct = Console.ReadKey().KeyChar;
            if (correct == 'y' || correct == 'Y')
            {
                petowner.OwnerAnimals.Add(new Pet(name,nickname, typeOfAnimal, birthdate));
                RecMenu.MenuView();
            }
            else
            {
                PetRegView(petowner);
            }
                Console.ReadKey();
        }
    }
}
