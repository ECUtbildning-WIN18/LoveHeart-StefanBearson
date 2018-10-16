using System;
using System.Linq;
using LoveHeart.Actions;
using LoveHeart.Domain;
using LoveHeart.Services;

namespace LoveHeart.Views
{
    class RecRegAppointment
    {
        public static void addAppointment()
        {
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();

            Tools.WriteAt(Config.fromBorder, 3, "Register Appointment");

            Tools.WriteAt(Config.fromBorder, 5, "Customer name:");
            Tools.WriteAt(Config.fromBorder, 6, "Customers pet name:");
            Tools.WriteAt(Config.fromBorder, 7, "Vet Name: ");
            Tools.WriteAt(Config.fromBorder, 8, "Notes: ");

            Console.SetCursorPosition(Config.fromBorder + 15, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Config.fromBorder + 20, 6);
            Console.ForegroundColor = ConsoleColor.Blue;
            string petName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Config.fromBorder + 10, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            string vetName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Config.fromBorder + 7, 8);
            Console.ForegroundColor = ConsoleColor.Blue;
            string note = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            var appointemnet = new Appointment(vetName, petName, petName, note);
            AppointmentSaver.AddOneAndSave(appointemnet);

            RecMenu.MenuView();
        }

        public static void ListVets()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("\tVets");
            foreach (var vet in Program.vets)
            {
                Console.WriteLine($"\t{vet.FirstName} {vet.LastName}");
            }
            Console.WriteLine("------------------------");
        }
    }
}
