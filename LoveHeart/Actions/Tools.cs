using LoveHeart.Views;
using System;

namespace LoveHeart.Actions
{
    class Tools
    {
        public static void WriteAt(int fromLeft, int fromTop, string text)
        {
            if (Program.speak)
                Program.synth.Speak(text);

            Console.SetCursorPosition(fromLeft, fromTop);
            Console.Write(text);
        }

        public static void WriteAt(int fromLeft, int fromTop, string text, ConsoleColor color)
        {
            if (Program.speak)
                Program.synth.Speak(text);

            Console.SetCursorPosition(fromLeft, fromTop);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteAt(string text, ConsoleColor color)
        {
            if (Program.speak)
                Program.synth.Speak(text);

            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteAt(string text)
        {
            if (Program.speak)
                Program.synth.Speak(text);

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

        public static void WrongUsernamePassword()
        {
            Tools.WriteAt(Config.fromBorder, 13, $"Wrong username and/or password");
            Tools.WriteAt(Config.fromBorder, 14, $"Do you want to try again? ");
            Tools.WriteAt("(Y)es ", ConsoleColor.DarkGreen);
            Tools.WriteAt("(N)o", ConsoleColor.DarkRed);
            Console.SetCursorPosition(Config.fromBorder, 16);
        }

        public static void WrongUsernamePasswordAction()
        {
            var chosenOption = Console.ReadKey().Key;

            if (chosenOption == ConsoleKey.Y)
            {
                LogIn.View();
            }
            else if (chosenOption == ConsoleKey.N)
            {
                Environment.Exit(0);
            }
        }
    }
}
