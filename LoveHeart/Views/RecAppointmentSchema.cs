using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Views
{
    class RecAppointmentSchema
    {
        public static void view()
        {
            Console.Clear();
            //HeaderView.Header();
            Console.SetBufferSize(80,3000);
            foreach (var vets in Program.vets)
            {
                Console.WriteLine("######################################");
                Console.WriteLine($"{vets.FirstName} {vets.LastName}");
                Console.WriteLine("--------------------------------------");
                foreach (var t in vets.schedule)
                {
                    Console.WriteLine($"\t{t.Key} : {t.Value}");
                }
                Console.WriteLine("######################################");
                Console.WriteLine();
            }
            
            Console.SetCursorPosition(0,0);
            
            
            Console.ReadKey();
            RecMenu.MenuView();
        }
    }
}
