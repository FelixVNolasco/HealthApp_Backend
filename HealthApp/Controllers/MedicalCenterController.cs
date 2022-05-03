
using DataAccess.Repositories;
using HealthApp.Dtos;
using HealthApp.Extensions;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("centers")]
    public class MedicalCenterController : ControllerBase
    {
        private readonly MedicalCenterRepository medicalCenterRepository;


        public MedicalCenterController(IMedicalCenterRepository<MedicalCenter> medicalCenterRepository)
        {
            this.medicalCenterRepository = (MedicalCenterRepository)medicalCenterRepository;
        }

        [HttpPost]
        public IActionResult CreateCenter(CreateMedicalCenterDto createMedicalCenterDto)
        {
            var medicalCenter = new MedicalCenter
            {
                address = createMedicalCenterDto.address,
                phoneNumber = createMedicalCenterDto.phoneNumber,
                rating = createMedicalCenterDto.rating
            };

            var responseStatusOk = medicalCenterRepository.CreateCenter(medicalCenter);

            if (responseStatusOk)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }

        [HttpGet]
        public IEnumerable<MedicalCenterDto> GetAllCenters()
        {
            var doctors = (medicalCenterRepository.GetAllCenters()).Select(medicalCenter => medicalCenter.AsDto());
            return doctors;
        }


        [HttpGet("{id}")]
        public IActionResult GetCenter(int id)
        {
            var particularDoctor = medicalCenterRepository.GetCenter(id);

            if (particularDoctor.id == 0)
            {
                return BadRequest("This Medical Center doesn't exists");
            }
            else
            {
                return Ok(particularDoctor);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCenter(int id, UpdateMedicalCenterDto updateMedicalCenterDto)
        {
            var existingCenter = medicalCenterRepository.GetCenter(id);

            if (existingCenter == null)
            {
                return BadRequest("The Medical Center doesn't exists");

            }

            existingCenter.phoneNumber = updateMedicalCenterDto.phoneNumber;

            var responseStatusOk = medicalCenterRepository.UpdateCenter(existingCenter);

            if (responseStatusOk)
            {
                return Ok("Succesfully Updated");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var responseStatusOk = medicalCenterRepository.RemoveCenter(id);

            if (responseStatusOk)
            {
                return Ok("Succesfully Deleted");
            }
            else
            {
                return BadRequest("Something Went Wrong");
            }
        }

    }
}
