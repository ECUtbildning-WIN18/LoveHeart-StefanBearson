using System;

namespace LoveHeart.Views
{
    class HeaderView
    {
        public static void Header()
        {
            Program.speak = false;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"# Vet Admin Software                       Logd in: {LogIn.userLogdIn}\t");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Program.speak = false;
        }
    }
}
