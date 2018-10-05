using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Actions;

namespace LoveHeart.Views
{
    class RecListCustomerView
    {
        public static void listView()
        {
            Console.Clear();
            HeaderView.Header();
            Console.SetBufferSize(80, 3000);
            Console.CursorVisible = false;
            int row = 2;
            foreach (var customer in Program.customers)
            {
                Tools.WriteAt(Config.fromBorder, row, $"{customer.Value.FirstName} {customer.Value.LastName} - {customer.Value.SocialSecurityNumber}", ConsoleColor.Blue);
                row++;

                foreach (var pet in customer.Value.OwnerAnimals)
                {
                    Tools.WriteAt(Config.fromBorder, row, $"  {pet.Name}");
                    Tools.WriteAt($", and that thing is a {pet.TypeOfAnimal}",ConsoleColor.DarkGray);
                    row++;
                }
            }
            Console.ReadKey();
            Console.CursorVisible = true;
            RecMenu.MenuView();
        }
    }
}
