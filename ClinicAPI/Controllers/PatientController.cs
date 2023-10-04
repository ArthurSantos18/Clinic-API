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
            var patients = await _patientRepository.GetAllPatientsAsync();

            List<PatientDto> result = new List<PatientDto>();

            foreach (var patient in patients)
            {
                result.Add(_mapper.Map<PatientDto>(patient));
            }

            if (result.Any()) {
                return Ok(result);
            }
            return BadRequest("Patients not founds");
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
            return BadRequest("Patient not founds");
        }

        [HttpPost]
        public async Task<IActionResult> Post(PatientAddDto patient)
        {
            if (patient != null)
            {
                var patientAdd = _mapper.Map<Patient>(patient);
                _patientRepository.Add(patientAdd);
                if (await _patientRepository.SaveChangeAsync())
                {
                    return Ok("Patient added");
                }
                return BadRequest("Patient was not saved");
            }
            return BadRequest("Invalid Data");
        }
    }
}
