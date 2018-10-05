using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class RecMenu
    {
        public static void MenuView()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.WriteLine("Receptionist Menu");
            Console.WriteLine();
            Console.WriteLine("1. Register new custemer");
            Console.WriteLine("2. Search custemer");
            Console.WriteLine("3. List cusomers");
            Console.WriteLine("----------------------------");
            Console.WriteLine("4. Registry appointment");
            Console.WriteLine("5. List appointments");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("E. Logout and exit");
            Char thePick = Console.ReadKey().KeyChar;

            switch (thePick)
            {
                case '1': RecRegisterView.View(); break;
                case '2': SearchView.Search(); break;
                case '3': RecListCustomerView.listView(); break;
                case '4': RecRegAppointment.addAppointment(); break;
                case '5': RecAppointmentSchema.view(); break;
                case 'E':
                case 'e': LogIn.View(); break;
                default: MenuView(); break;
            }
            Console.ReadKey();
        }
    }
}
