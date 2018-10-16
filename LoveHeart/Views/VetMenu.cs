using LoveHeart.Actions;
using System;

namespace LoveHeart.Views
{
    class VetMenu
    {
        public static void menuView()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();

            Tools.WriteAt(Config.fromBorder, 3, "Vet Menu");
            Tools.WriteAt(Config.fromBorder, 4, "Not jet ready!");
            Tools.WriteAt(Config.fromBorder, 6, "Press any key to go back to login!", ConsoleColor.DarkRed);
            Console.ReadKey();
            LogIn.View();
        }
    }
}
