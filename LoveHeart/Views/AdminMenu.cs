using System;
using LoveHeart.Actions;

namespace LoveHeart.Views
{
    class AdminMenu
    {
        public static void menuView()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            
            Tools.WriteAt(Config.fromBorder, 3, "Admin menu");
            Tools.WriteAt(Config.fromBorder, 4, "Not jet ready!");
            Tools.WriteAt(Config.fromBorder, 6, "Press any key to go back to login!", ConsoleColor.DarkRed);

            Console.ReadKey();
            LogIn.View();
        }
    }
}
