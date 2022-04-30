using HealthApp.Dtos;
using Models.Entities;

namespace HealthApp.Extensions
{
    public static class Extensions
    {
        public static DoctorDto AsDto(this Doctor doctor)
        {
            return new DoctorDto(doctor.id, doctor.firstname, doctor.lastname, doctor.birthdate, doctor.graduation_date, doctor.phone_number, doctor.email);
        }
    }
}
