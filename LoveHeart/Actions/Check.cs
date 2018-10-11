using LoveHeart.Domain;
using LoveHeart.Views;
using System;

namespace LoveHeart.Actions
{
    class Check
    {
        public static void RoleAndSend(User user)
        {
            if (user.UserRole == "rec")
            {
                RecMenu.MenuView();
            }
            else if (user.UserRole == "vet")
            {
                VetMenu.menuView();
            }
            else if (user.UserRole == "admin")
            {
                AdminMenu.menuView();
            }
            else
            {
                Tools.WriteAt(Config.fromBorder, 4, $"Wrong User role", ConsoleColor.Red);
                Console.ReadKey();
            }
        }
    }
}
