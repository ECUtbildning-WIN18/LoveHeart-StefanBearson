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
                        Console.WriteLine($"{userName} wants to log in!");
                        Console.WriteLine();
                        Console.WriteLine("Is this correct? (Y)es (N)o");
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
                                Console.WriteLine("error!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Login failed, please try again");
                            Console.ReadKey();
                            View();
                        }
                        
                        

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"You have {3 - trys} left!");
                        Console.WriteLine();
                        Console.Write("Password: ");
                        password = SecretPassword.EnterPassword();
                        trys++;
                    }
                }

                Console.WriteLine("Contact Admin for support!");
                View();


            }
            else
            {
                Console.Clear();
                Console.WriteLine("User dont exist! Try Again...");
                Console.ReadKey();
                View();
            }
            

        }
    }
}
