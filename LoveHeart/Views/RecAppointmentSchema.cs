using LoveHeart.Actions;
using System;
using LoveHeart.Services;

namespace LoveHeart.Views
{
    class RecAppointmentSchema
    {
        public static void view()
        {
            Console.Clear();
            Console.SetBufferSize(80, 3000);
            Console.CursorVisible = false;

            AppointmentLoader loader = new AppointmentLoader();
            var appointments = loader.LoadAppointments();

            int row = 3;

            foreach (var appointment in appointments)
            {
                Tools.WriteAt(Config.fromBorder, row, $"{appointment.Vet}", ConsoleColor.Yellow);
                Tools.WriteContinue($", {appointment.PetOwner}, {appointment.Pet}", ConsoleColor.DarkYellow);
                row++;
                Tools.WriteAt(Config.fromBorder, row, $"{appointment.Note}", ConsoleColor.DarkYellow);
                row++;
            }
            
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
            Console.CursorVisible = true;
            RecMenu.MenuView();
        }
    }
}
