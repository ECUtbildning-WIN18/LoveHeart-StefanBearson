using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class HeaderView
    {
        public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"# Vet Admin Software                       Logd in: {LogIn.userLogdIn}\t");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
