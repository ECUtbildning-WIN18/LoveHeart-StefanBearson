using LoveHeart.Domain;
using System.Collections.Generic;

namespace LoveHeart.Services
{
    interface IAppointmentLoader
    {
        List<Appointment> LoadAppointments();
    }
}
