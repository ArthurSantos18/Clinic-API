using AutoMapper;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        public PatientController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _patientRepository.GetAllPatientsAsync();

            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("Patients not founds");
        }

        [HttpGet("(Id)")]
        public async Task<IActionResult> GetById(int id)
        {
            var patient = await _patientRepository.GetByIdAsync(id);

            var result = _mapper.Map<PatientDetailsDto>(patient);
            
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("Patient not founds");
        }

        [HttpPost]
        public async Task<IActionResult> Post(PatientAddDto patient)
        {
            if (patient != null)
            {
                var result = _mapper.Map<Patient>(patient);
                _patientRepository.Add(result);
                if (await _patientRepository.SaveChangeAsync())
                {
                    return Ok("Patient added");
                }
                return BadRequest("Patient was not saved");
            }
            return BadRequest("Invalid Data");
        }

        [HttpPut("(Id)")]
        public async Task<IActionResult> Put(int id, PatientUpdateDto patient)
        {
            if (id > 0)
            {
                var patientDatabase = await _patientRepository.GetByIdAsync(id);
                var result = _mapper.Map(patient, patientDatabase);

                _patientRepository.Update(result);

                if (await _patientRepository.SaveChangeAsync())
                {
                    return Ok("Patient updated");
                }
                return BadRequest("Patient was not update");
            }
            return BadRequest("Invalid Id");
        }

        [HttpDelete("(Id)")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var result = await _patientRepository.GetByIdAsync(id);
                

                if (result != null)
                {
                    _patientRepository.Delete(result);
                    await _patientRepository.SaveChangeAsync();
                    return Ok("Patient deleted");
                }
                return NotFound("Patient not found");
            }
            return BadRequest("Invalid Id");
        }
    }
}
