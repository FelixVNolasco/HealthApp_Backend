using HealthApp.Dtos;
using Models.Entities;

namespace HealthApp.Extensions
{
    public static class Extensions
    {
        public static DoctorDto AsDto(this Doctor student)
        {
            return new DoctorDto();
        }
    }
}
