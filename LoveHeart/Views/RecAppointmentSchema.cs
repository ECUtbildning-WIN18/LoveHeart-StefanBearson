using LoveHeart.Actions;
using System;

namespace LoveHeart.Views
{
    class RecAppointmentSchema
    {
        public static void view()
        {
            Console.Clear();
            Console.SetBufferSize(80, 3000);
            Console.CursorVisible = false;

            int row = 1;

            foreach (var vets in Program.vets)
            {
                Tools.WriteAt(0, row, "######################################");
                row++;
                Tools.WriteAt(1, row, $"{vets.FirstName} {vets.LastName}", ConsoleColor.Blue);
                row++;
                Tools.WriteAt(0, row, "--------------------------------------");
                row++;
                foreach (var t in vets.schedule)
                {
                    Tools.WriteAt(1, row, $"  {t.Key} \t {t.Value}");
                    row++;
                }
                Tools.WriteAt(0, row, "######################################");
                Console.WriteLine();
            }

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
            Console.CursorVisible = true;
            RecMenu.MenuView();
        }
    }
}
