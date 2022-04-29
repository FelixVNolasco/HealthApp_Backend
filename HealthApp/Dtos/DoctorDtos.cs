using System.ComponentModel.DataAnnotations;

namespace HealthApp.Dtos
{

    public record DoctorDto(
        //int id, 
        //string firstName, 
        //string lastName, 
        //string email, 
        //string career, 
        //string school, 
        //bool signedUp
        );

    public record CreateDoctorDto(
        //[Required] string firstName, 
        //string boleta, 
        //string lastName, 
        //string email, 
        //string career, 
        //string school, 
        //bool signedUp
        );

    public record UpdateDoctorDto(
        //[Required] string firstName, 
        //string boleta, 
        //string lastName, 
        //string email
        );

}
