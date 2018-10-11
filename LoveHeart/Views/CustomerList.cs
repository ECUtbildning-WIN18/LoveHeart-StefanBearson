using LoveHeart.Services;
using System;
using System.Collections.Generic;
using LoveHeart.Domain;

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
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} : {customer.SocialSecurityNumber}");

                foreach (var pet in customer.OwnerAnimals)
                {

                    Console.WriteLine($"\t{pet.Name} is a {pet.TypeOfAnimal}");
                }
            }
        }
    }
}
