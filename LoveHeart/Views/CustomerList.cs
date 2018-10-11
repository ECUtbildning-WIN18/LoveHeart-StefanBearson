using LoveHeart.Services;
using System;

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

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} : {customer.SocialSecurityNumber}");

                foreach (var pet in customer.OwnerAnimals)
                {

                    Console.WriteLine($"\t{pet.Name} is a {pet.TypeOfAnimal}");
                }
            }

            Console.ReadKey();
            RecMenu.MenuView();
        }
    }
}
