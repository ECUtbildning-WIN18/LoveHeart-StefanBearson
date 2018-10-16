using LoveHeart.Actions;
using LoveHeart.Domain;
using LoveHeart.Services;
using System;
using System.ComponentModel;

namespace LoveHeart.Views
{
    class LogIn
    {
        public static string userLogdIn = "";
        public static string role = "";

        public static void View()
        {
            userLogdIn = "";

            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            
            SecretText();

            Tools.WriteAt(Config.fromBorder, 4, "Please Log in");

            Tools.WriteAt(Config.fromBorder, 5, "Username: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Tools.WriteAt(Config.fromBorder, 6, "Password:  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string password = SecretPassword.EnterPassword();
            Console.ForegroundColor = ConsoleColor.White;

            var authenticationService = new AuthenticationService();
            var user = authenticationService.Authenticate(username, password);

            CheckIfNotNull(user);
            Console.ReadKey();
        }

        public static void SecretText()
        {
            var loadUsers = new UserLoader();
            var users = loadUsers.LoadUsers();

            Tools.WriteAt(Config.fromBorder, 8, "This text does not exist!!!", ConsoleColor.DarkGray);

            Tools.WriteAt(Config.fromBorder, 10, "Username\t\tPassword\tRole", ConsoleColor.DarkGray);
            int row = 11;

            foreach (var user in users)
            {
                Tools.WriteAt(Config.fromBorder, row, $"{user.UserName}\t\t{user.Password}\t\t{user.UserRole}", ConsoleColor.DarkBlue);
                row++;
            }
        }

        public static void CheckIfNotNull(User user)
        {
            if (user != null)
            {
                userLogdIn = user.UserName;
                Check.RoleAndSend(user);
            }
            else
            {
                Tools.WrongUsernamePassword();
                Tools.WrongUsernamePasswordAction();
            }
        }
    }
}
