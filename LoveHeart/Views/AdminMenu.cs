using System;

namespace LoveHeart.Views
{
    class AdminMenu
    {
        public static void menuView()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.WriteLine();
            Console.WriteLine("admin menu");
            Console.ReadKey();
        }
    }
}
