using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using LoveHeart.Domain;

namespace LoveHeart.Views
{
    class RecRegAppointment
    {
        public static void addAppointment()
        {
            Console.Clear();
            HeaderView.Header();
            Console.WriteLine();
            Console.WriteLine("Register Appointment");
            Console.WriteLine();
            Console.WriteLine("Pet name:");
            string petName = Console.ReadLine();
            //add check if per exist
            ListVets();
            Console.WriteLine("Veterainarian (first name): ");
            string vetName = Console.ReadLine();
            //var myKey = types.FirstOrDefault(x => x.Value == "one").Key;
            string vetId = Program.vets.FirstOrDefault(name => name.FirstName == vetName).VetId;
            if (Program.vets.Any(vet => vet.FirstName == vetName))
            {
                Console.WriteLine("Date (yyyy-mm-dd hh:mm):");
                DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                if (Program.vets.Any(time => time.schedule.ContainsKey(dateTime)))
                {
                    Console.Clear();
                    Console.WriteLine("Not free!");
                    Console.ReadKey();
                }
                else
                {
                    foreach (var vet in Program.vets)
                    {
                        vet.schedule.Add(dateTime, petName);
                        RecMenu.menuView();
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Vet do not exist");
                Console.ReadKey();
                addAppointment();
            }
            


            
            Console.ReadKey();
            RecMenu.menuView();
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
