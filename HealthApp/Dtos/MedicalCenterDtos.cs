
using System.ComponentModel.DataAnnotations;

namespace HealthApp.Dtos
{
    public record MedicalCenterDto(
        int id,
        string address,
        string phoneNumber,
        string rating
        );

    public record CreateMedicalCenterDto(
        [Required]
        string address,
        string phoneNumber,
        string rating
        );

    public record UpdateMedicalCenterDto(
        [Required]
        string phoneNumber
        );
}
