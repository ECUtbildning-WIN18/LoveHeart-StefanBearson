using LoveHeart.Actions;
using LoveHeart.Domain;
using System;

namespace LoveHeart.Views
{
    class RecRegisterView
    {
        public static void View()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();

            Tools.WriteAt(Config.fromBorder, 4, "# Register new customer");

            Tools.WriteAt(Config.fromBorder, 6, "First name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string firstName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.WriteAt(Config.fromBorder, 7, "Last name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string lastName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.WriteAt(Config.fromBorder, 8, "Social Security Number (yymmdd-xxxx): ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string socialSecutityNumber = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.IsThisCorrectText();
            char correct = Console.ReadKey().KeyChar;

            if (correct == 'y' || correct == 'Y')
            {
                if (Program.customers.ContainsKey(socialSecutityNumber))
                {
                    Tools.WriteAt(Config.fromBorder, 7, "Customer already exist.", ConsoleColor.DarkRed);
                    Tools.WriteAt(Config.fromBorder, 9, "Press any key to continue...", ConsoleColor.DarkRed);
                    Console.ReadKey();
                    RecRegisterView.View();
                }
                else
                {
                    PetOwner petowner = new PetOwner(firstName, lastName, socialSecutityNumber);
                    Program.customers.Add(petowner.SocialSecurityNumber, petowner);
                    //CustomerSaver.AddOneAndSave(petowner);
                    RecRegisterPetView.PetRegView(petowner);
                }
            }
            else
            {
                RecMenu.MenuView();
            }
        }
    }
}
