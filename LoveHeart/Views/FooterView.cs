using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class FooterView
    {
        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.SetWindowSize(65,20);
            Console.SetBufferSize(70, 20);
            Console.SetCursorPosition(0,18);
            Console.WriteLine($"###########################################################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0,2);
        }
    }
}
