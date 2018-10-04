using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Vet
    {
        public Dictionary<DateTime, string> schedule = new Dictionary<DateTime, string>();

        public string VetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Vet(string vetId, string firstName, string lastName)
        {
            VetId = vetId;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddAppointment(DateTime date, string pet)
        {
            //schedule.Add(new DateTime(2018,07,08,14,00,00),"test" );
            schedule.Add(date, pet);
        }
    }
}
