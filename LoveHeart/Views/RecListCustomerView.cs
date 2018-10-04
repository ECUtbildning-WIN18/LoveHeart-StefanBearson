using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class RecListCustomerView
    {
        public static void listView()
        {
            Console.Clear();
            foreach (var customer in Program.customers)
            {
                Console.WriteLine($"{customer.Value.FirstName} {customer.Value.LastName} - {customer.Value.SocialSecurityNumber}");

                foreach (var pet in customer.Value.OwnerAnimals)
                {
                    Console.WriteLine($"\t\t{pet.Name}, and that thing is a {pet.TypeOfAnimal}");
                }
            }

            Console.ReadKey();
            RecMenu.menuView();

        }
    }
}
