using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Actions;

namespace LoveHeart.Views
{
    class FooterView
    {
        public static void Footer()
        {
            Program.speak = false;
            Console.SetWindowSize(65,20);
            Console.SetBufferSize(70, 20);
            Tools.WriteAt(0, 18, $"###########################################################", ConsoleColor.DarkRed);
            Tools.WriteAt(0, 19, $"A StefanBearson Solution", ConsoleColor.DarkRed);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0,2);
            Program.speak = true;
        }
    }
}
