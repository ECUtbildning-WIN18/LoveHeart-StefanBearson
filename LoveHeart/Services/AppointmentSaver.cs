using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LoveHeart.Domain;

namespace LoveHeart.Services
{
    class AppointmentSaver
    {
        public static void AddOneAndSave(Appointment appointment)
        {
            var appointments = XDocument.Load("Appointment.xml");

            var root = appointments.Root;

            var appointmentinfo = new XElement("Appointment",
                new XAttribute("vet", appointment.Vet),
                new XAttribute("petowner", appointment.PetOwner),
                new XAttribute("pet", appointment.Pet),
                new XAttribute("note", appointment.Note));
            
            root.Add(appointmentinfo);

            appointments.Save("Appointment.xml");
        }
    }
}
