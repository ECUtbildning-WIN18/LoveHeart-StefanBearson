using LoveHeart.Actions;
using LoveHeart.Domain;
using LoveHeart.Services;
using System;
using System.Collections.Generic;

namespace LoveHeart.Views
{
    class CustomerList
    {
        public static void PrintCustomerList()
        {
            Console.Clear();
            HeaderView.Header();
            Console.SetBufferSize(80, 3000);
            Console.CursorVisible = false;

            CustomerAndPetLoader customerLoader = new CustomerAndPetLoader();
            var customers = customerLoader.LoadUsers();

            PrintToView(customers);

            Console.ReadKey();
            RecMenu.MenuView();
        }

        public static void PrintToView(List<PetOwner> customers)
        {
            int row = 3;
            foreach (var customer in customers)
            {
                Tools.WriteAt(Config.fromBorder, row, $"{customer.FirstName} {customer.LastName} : {customer.SocialSecurityNumber}", ConsoleColor.DarkYellow);
                row++;
                foreach (var pet in customer.OwnerAnimals)
                {
                    Tools.WriteAt(Config.fromBorder, row, $"  {pet.Name}:", ConsoleColor.DarkGray);
                    Tools.WriteAt(Config.fromBorder + 30, row, $"  {pet.TypeOfAnimal}", ConsoleColor.DarkGray);
                    row++;
                }
            }
        }
    }
}
