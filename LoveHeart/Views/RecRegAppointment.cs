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
            //TODO: Console.WriteLine to Tools.WriteAt...
            Console.Clear();
            HeaderView.Header();
            FooterView.Footer();
            Console.WriteLine("Register Appointment");
            Console.WriteLine();
            Console.WriteLine("Pet name:");
            string petName = Console.ReadLine();

            if (Program.customers.Any(custemor => custemor.Value.OwnerAnimals.Any(pet => pet.Name.Contains(petName))))
            {
                Console.WriteLine("Reason:");
                string addNote = Console.ReadLine();
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
                            foreach (var owner in Program.customers.Values)
                            {
                                foreach (var pet in owner.OwnerAnimals)
                                {
                                    if (pet.Name == petName)
                                    {
                                        pet.Notes.Add(addNote);
                                    }
                                }
                            }
                            vet.schedule.Add(dateTime, petName);
                            RecMenu.MenuView();
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
            }
            Console.ReadKey();
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
