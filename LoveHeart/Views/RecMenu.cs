using LoveHeart.Actions;
using System;

namespace LoveHeart.Views
{
    class RecMenu
    {
        public static void MenuView()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.CursorVisible = false;
            Tools.WriteAt(Config.fromBorder, 4, "Receptionist Menu");
            Tools.WriteAt(Config.fromBorder, 6, "(1) Register new custemer");
            Tools.WriteAt(Config.fromBorder, 7, "(2) Search custemer");
            //Tools.WriteAt(Config.fromBorder, 8, "3. List customers");
            Tools.WriteAt(Config.fromBorder, 8, "(3) Registry appointment");
            Tools.WriteAt(Config.fromBorder, 10, "(4) List appointments");
            Tools.WriteAt(Config.fromBorder, 11, "(5) List customers");
            Tools.WriteAt(Config.fromBorder, 13, "(E) Logout and exit");

            ChoseOnMenuViewAction();
        }

        public static void ChoseOnMenuViewAction()
        {
            Char thePick = Console.ReadKey().KeyChar;
            Console.CursorVisible = true;

            switch (thePick)
            {
                case '1': RecRegisterView.View(); break;
                case '2': SearchView.Search(); break;
                //case '3': RecListCustomerView.listView(); break;
                case '3': RecRegAppointment.addAppointment(); break;
                case '4': RecAppointmentSchema.view(); break;
                case '5': CustomerList.PrintCustomerList(); break;
                case 'E':
                case 'e':
                    LogIn.userLogdIn = ""; LogIn.View(); break;
                default: MenuView(); break;
            }
        }
    }
}
