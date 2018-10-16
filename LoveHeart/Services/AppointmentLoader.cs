using LoveHeart.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LoveHeart.Services
{
    class AppointmentLoader : IAppointmentLoader
    {
        public List<Appointment> LoadAppointments()
        {
            var appointments = new List<Appointment>();

            var doc = XDocument.Load("Appointment.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var vet = element.Attribute("vet").Value;
                var petOwner = element.Attribute("petowner").Value;
                var pet = element.Attribute("pet").Value;
                var note = element.Attribute("note").Value;

                appointments.Add(new Appointment(vet, petOwner, pet, note));
            }
            return appointments;
        }
    }
}
