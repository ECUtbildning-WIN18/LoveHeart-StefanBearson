﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class VetMenu
    {
        public static void menuView()
        {
            Console.Clear();
            HeaderView.Header();
            Console.WriteLine();
            Console.WriteLine("vet menu");
            Console.ReadKey();
        }
    }
}
