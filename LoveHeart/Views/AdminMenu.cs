﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
