using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Actions;

namespace LoveHeart.Views
{
    class SearchView
    {
        public static void Search()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Tools.WriteAt(Config.fromBorder, 4, "Search customer");
            
            Tools.WriteAt(Config.fromBorder, 6, "Search social security number (yymmdd-xxxx)");
            Tools.WriteAt(Config.fromBorder, 8, "yymmdd-xxxx");
            Console.SetCursorPosition(Config.fromBorder, 8);

            string ssn = Console.ReadLine();
            
            if (Program.customers.ContainsKey(ssn))
            {
                Console.Clear();
                HeaderView.Header();
                FooterView.Footer();
                Tools.WriteAt(Config.fromBorder, 4, $"{Program.customers[ssn].FirstName} {Program.customers[ssn].LastName}: {Program.customers[ssn].SocialSecurityNumber}");
                Tools.WriteAt(Config.fromBorder, 5, $"\tPets:");


                int row = 0;
                foreach (var customer in Program.customers[ssn].OwnerAnimals)
                {
                    Tools.WriteAt(Config.fromBorder, 6 + row, $"\t{customer.Name}, {customer.NickName} is a {customer.TypeOfAnimal}", ConsoleColor.Blue);
                    row++;
                    foreach (var note in customer.Notes)
                    {
                        Tools.WriteAt(Config.fromBorder,6 + row, $"\t\t{note}",ConsoleColor.Green);
                        row++;
                    }
                }
                Tools.WriteAt(Config.fromBorder, 8 + row, $"Press any key to continue...", ConsoleColor.DarkRed);
                Console.ReadKey();
                RecMenu.MenuView();
            }
            else
            {
                Tools.WriteAt(Config.fromBorder, 10, "Custemor not found!", ConsoleColor.DarkRed);
                Tools.WriteAt(Config.fromBorder, 11, "Press any key...", ConsoleColor.DarkRed);
                Console.ReadKey();
                Search();
            }
        }
    }
}
