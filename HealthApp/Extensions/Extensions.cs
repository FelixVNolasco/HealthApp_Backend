using HealthApp.Dtos;
using Models.Entities;

namespace HealthApp.Extensions
{
    public static class Extensions
    {
        public static DoctorDto AsDto(this Doctor doctor)
        {
            return new DoctorDto(doctor.id, doctor.firstname, doctor.lastname, doctor.birthdate, doctor.graduation_date, doctor.phone_number, doctor.email, doctor.specialty);
        }

        public static ClinicalSpecialtyDto AsDto(this ClinicalSpecialty clinicalSpecialty)
        {
            return new ClinicalSpecialtyDto(clinicalSpecialty.id, clinicalSpecialty.field, clinicalSpecialty.specialty, clinicalSpecialty.description);
        }
    }
}
