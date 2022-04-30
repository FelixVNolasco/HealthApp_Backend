using System.ComponentModel.DataAnnotations;

namespace HealthApp.Dtos
{

    public record DoctorDto(
        int id,
        string firstName,
        string lastName,
        string birthdate,
        string graduation_date,
        string phone_number,
        string email
        );

    public record CreateDoctorDto(
        [Required] 
        string firstName,
        string lastName,
        string birthdate,
        string graduation_date,
        string phone_number,
        string email                       
        );

    public record UpdateDoctorDto(
        [Required]
        string firstName,
        string lastName,
        string birthdate,
        string phone_number,
        string email
        );

}
