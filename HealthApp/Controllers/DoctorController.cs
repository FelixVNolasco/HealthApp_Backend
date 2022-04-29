using DataAccess.Repositories;
using HealthApp.Dtos;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces;
using System.Collections.Generic;
using HealthApp.Extensions;
using System.Linq;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("doctores")]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorRepository doctorRepository;

        public DoctorController(IRepository<Doctor> doctorRepository)
        {
            this.doctorRepository = (DoctorRepository)doctorRepository;
        }

        [HttpPost]
        public IActionResult CreateDoctor(CreateDoctorDto doctor)
        {

            var newDoctor = new Doctor
            {

            };
            doctorRepository.CreateDoctor(newDoctor);

            return Ok(newDoctor);
            //return newDoctor;
        }

        [HttpGet]
        public IEnumerable<DoctorDto> GetAllStudents()
        {
            var doctors= (doctorRepository.GetAllDoctors()).Select(doctor => doctor.AsDto());
            return doctors;
        }

        [HttpGet("{id}")]
        public DoctorDto GetDoctor(int id)
        {
            var particularDoctor = doctorRepository.GetDoctor(id);
            return particularDoctor.AsDto();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, UpdateDoctorDto doctor)
        {
            var existingDoctor = doctorRepository.GetDoctor(id);
            if (existingDoctor == null)
            {
                return BadRequest();

            }
            doctorRepository.UpdateDoctor(existingDoctor);
            //doctorRepository.UpdateDoctor(doctor);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var deletedDoctor = doctorRepository.RemoveDoctor(id);

            return Ok(deletedDoctor);
            //return deletedDoctor;
        }

    }
}
