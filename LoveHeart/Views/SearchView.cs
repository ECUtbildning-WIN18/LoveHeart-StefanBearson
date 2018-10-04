using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class SearchView
    {
        public static void Search()
        {
            Console.Clear();
            Console.WriteLine("# Search customer");
            Console.WriteLine();
            Console.WriteLine("Search social security number (yymmdd-xxxx)");
            string ssn = Console.ReadLine();
            Console.WriteLine();
            if (Program.customers.ContainsKey(ssn))
            {
                Console.WriteLine($"{Program.customers[ssn].FirstName} {Program.customers[ssn].LastName}: {Program.customers[ssn].SocialSecurityNumber}");
                Console.WriteLine("\tPets:");
                foreach (var customer in Program.customers[ssn].OwnerAnimals)
                {
                    Console.WriteLine($"\t{customer.Name}, {customer.NickName} is a {customer.TypeOfAnimal}");
                }

                Console.ReadKey();
                RecMenu.menuView();
            }
            else
            {
                Search();
            }

        }
    }
}
