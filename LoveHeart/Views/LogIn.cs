using System;
using System.Linq;
using LoveHeart.Actions;

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
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (Program.users.ContainsKey(userName))
            {
                Tools.WriteAt(Config.fromBorder, 6, "Password:  ");
                string password = SecretPassword.EnterPassword();
                var trys = 0;

                while (trys < 3)
                {
                    if (Program.users.Any(entry => entry.Key == userName && entry.Value.Password == password))
                    {
                        Console.Clear();
                        Tools.WriteAt(Config.fromBorder ,4, $"{userName}",ConsoleColor.Blue);
                        Tools.WriteAt(" wants to log in!");
                        Tools.IsThisCorrectText();
                        char correct = Console.ReadKey().KeyChar;
                        if (correct == 'y' || correct == 'Y')
                        {
                            userLogdIn = userName;
                            if (Program.users[userName].UserRole == "vet")
                            {
                                VetMenu.menuView();
                            }
                            else if (Program.users[userName].UserRole == "rec")
                            {
                                RecMenu.MenuView();
                            }
                            else if (Program.users[userName].UserRole == "admin")
                            {
                                AdminMenu.menuView();
                            }
                            else
                            {
                                Tools.WriteAt(Config.fromBorder, 8, $"Wrong User role", ConsoleColor.Red);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Tools.WriteAt(Config.fromBorder, 8,$"Login failed, please try again", ConsoleColor.Red);
                            Console.ReadKey();
                            View();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        HeaderView.Header();
                        FooterView.Footer();
                        Tools.WriteAt(Config.fromBorder, 8, $"Wrong Password", ConsoleColor.Red);
                        Tools.WriteAt(Config.fromBorder, 10, $"You have {3 - trys} left!", ConsoleColor.Red);
                        Tools.WriteAt(Config.fromBorder, 12, $"Password: ", ConsoleColor.Red);
                        password = SecretPassword.EnterPassword();
                        trys++;
                    }
                }
                Console.Clear();
                HeaderView.Header();
                FooterView.Footer();
                Tools.WriteAt(Config.fromBorder, 8, $"Contact Admin for support!", ConsoleColor.Red);
                Console.ReadKey();
                View();
            }
            else
            {
                Console.Clear();
                HeaderView.Header();
                FooterView.Footer();
                Tools.WriteAt(Config.fromBorder, 8, $"User dont exist! Try Again...", ConsoleColor.Red);
                Console.ReadKey();
                View();
            }
        }
    }
}
