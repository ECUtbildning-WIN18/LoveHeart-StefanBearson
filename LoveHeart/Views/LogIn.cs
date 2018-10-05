using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading;
using LoveHeart.Actions;
using LoveHeart.Domain;
using Microsoft.Win32.SafeHandles;


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
            //int a = 8;
            //int b = 3;
            //Console.SetWindowSize(a,b);

            //for (int i = 0; i < 10; i++)
            //{
            //    a += 8;
            //    b += 3;
            //    Console.SetWindowSize(a,b);
            //    Thread.Sleep(200);
            //}
            
            Console.WriteLine("Please Log in");
            Console.WriteLine();
            Console.Write("UserName: ");
            string userName = Console.ReadLine();
            if (Program.users.ContainsKey(userName))
            {
                Console.Write("Password: ");
                string password = SecretPassword.EnterPassword();

                var trys = 0;

                while (trys < 3)
                {
                    if (Program.users.Any(entry => entry.Key == userName && entry.Value.Password == password))
                    {
                        Console.Clear();

                        Tools.WriteAt(8,8, $"{userName}",ConsoleColor.Blue);
                        Tools.WriteAt(" wants to log in!");
                        Tools.WriteAt(8, 10, $"Is this correct? ");
                        Tools.WriteAt("(Y)es ", ConsoleColor.DarkGreen);
                        Tools.WriteAt("(N)o", ConsoleColor.DarkRed);
                        Console.SetCursorPosition(8, 12);
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
                                RecMenu.menuView();
                            }
                            else if (Program.users[userName].UserRole == "admin")
                            {
                                AdminMenu.menuView();
                            }
                            else
                            {
                                Tools.WriteAt(2, 8, $"Wrong User role", ConsoleColor.Red);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Tools.WriteAt(2,8,$"Login failed, please try again", ConsoleColor.Red);
                            Console.ReadKey();
                            View();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        HeaderView.Header();
                        FooterView.Footer();
                        Tools.WriteAt(2, 8, $"Wrong Password", ConsoleColor.Red);
                        Tools.WriteAt(2, 10, $"You have {3 - trys} left!", ConsoleColor.Red);
                        Tools.WriteAt(2, 12, $"Password: ", ConsoleColor.Red);
                        password = SecretPassword.EnterPassword();
                        trys++;
                    }
                }
                Console.Clear();
                HeaderView.Header();
                FooterView.Footer();
                Tools.WriteAt(2, 8, $"Contact Admin for support!", ConsoleColor.Red);
                Console.ReadKey();
                View();
            }
            else
            {
                Console.Clear();
                HeaderView.Header();
                FooterView.Footer();
                Tools.WriteAt(2, 8, $"User dont exist! Try Again...", ConsoleColor.Red);
                Console.ReadKey();
                View();
            }
        }
    }
}
