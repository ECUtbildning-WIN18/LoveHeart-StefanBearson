using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Domain;

namespace LoveHeart.Views
{
    class RecRegisterView
    {
        public static void View()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.WriteLine("# Register new customer");
            Console.WriteLine();
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Social Security Number (yymmdd-xxxx): ");
            string socialSecutityNumber = Console.ReadLine();

            Console.WriteLine("Is this correct? (Y)es (N)o");
            char correct = Console.ReadKey().KeyChar;
            if (correct == 'y' || correct == 'Y')
            {
                if (Program.customers.ContainsKey(socialSecutityNumber))
                {
                    Console.WriteLine("Customer already exist.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    RecRegisterView.View();
                }
                else
                {
                    PetOwner petowner = new PetOwner(firstName, lastName, socialSecutityNumber);
                    Program.customers.Add(petowner.SocialSecurityNumber, petowner);
                    RecRegisterPetView.PetRegView(petowner);
                }
            }
            else
            {
                RecMenu.menuView();
            }
        }
    }
}
