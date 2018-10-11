using LoveHeart.Actions;
using LoveHeart.Services;
using System;

namespace LoveHeart.Views
{
    class LogIn
    {
        public static string userLogdIn = "";
        public static string role = "";

        public static void View()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            userLogdIn = "";

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

            var userLoader = new UserLoader();

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
            Console.ReadKey();
        }
    }
}
