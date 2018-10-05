using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class AppointmentInitDB
    {
        public static void add()
        {
            foreach (var vet in Program.vets)
            {
                if (vet.VetId == "0001")
                {
                    vet.schedule.Add(new DateTime(2018,09,09,14,00,00), "Pelle" );
                    vet.schedule.Add(new DateTime(2018, 09, 09, 16, 00, 00), "Tudor");
                    vet.schedule.Add(new DateTime(2018, 09, 09, 17, 00, 00), "Charles");
                    vet.schedule.Add(new DateTime(2018, 09, 10, 10, 00, 00), "Fido");
                    vet.schedule.Add(new DateTime(2018, 09, 10, 08, 00, 00), "Kisse");
                }else if (vet.VetId == "0002")
                {
                    vet.schedule.Add(new DateTime(2018, 09, 09, 10, 00, 00), "Björnen Olle");
                    vet.schedule.Add(new DateTime(2018, 09, 09, 14, 00, 00), "Molle");
                    vet.schedule.Add(new DateTime(2018, 09, 09, 17, 00, 00), "Julia");
                    vet.schedule.Add(new DateTime(2018, 09, 10, 15, 00, 00), "Nilkas");
                    vet.schedule.Add(new DateTime(2018, 09, 10, 19, 00, 00), "Thor");
                }
                else
                {
                    Console.WriteLine("Nothing else...");
                }
            }
        }
    }
}
