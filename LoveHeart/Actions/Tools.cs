using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Actions
{
    class Tools
    {
        public static void WriteAt(int fromLeft, int fromTop, string text)
        {
            Console.SetCursorPosition(fromLeft,fromTop);
            Console.Write(text);
        }

        public static void WriteAt(int fromLeft, int fromTop, string text, ConsoleColor color)
        {
            Console.SetCursorPosition(fromLeft, fromTop);

            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteAt(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteAt(string text)
        {
            Console.Write(text);
        }

        public static void IsThisCorrectText()
        {
            Tools.WriteAt(Config.fromBorder, 10, $"Is this correct? ");
            Tools.WriteAt("(Y)es ", ConsoleColor.DarkGreen);
            Tools.WriteAt("(N)o", ConsoleColor.DarkRed);
            Console.SetCursorPosition(8, 12);
        }

        public static void IsThisCorrectTextLower()
        {
            Tools.WriteAt(Config.fromBorder, 14, $"Is this correct? ");
            Tools.WriteAt("(Y)es ", ConsoleColor.DarkGreen);
            Tools.WriteAt("(N)o", ConsoleColor.DarkRed);
            Console.SetCursorPosition(8, 16);
        }
    }
}
