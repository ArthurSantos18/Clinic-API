using AutoMapper;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _appointmentRepository.GetAllAppointmentsAsync();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("Appointments not founds");
        }

        [HttpGet("(Id)")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id > 0)
            {
                var appointment = await _appointmentRepository.GetByIdAsync(id);
                var result = _mapper.Map<AppointmentDetailsDto>(appointment);

                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound("Appointment not found");
            }
            return BadRequest("Invalid Id");
        }

        [HttpPost]
        public async Task<IActionResult> Post(AppointmentAddDto appointment)
        {
            if (appointment != null)
            {
                var result = _mapper.Map<Appointment>(appointment);
                _appointmentRepository.Add(result);
                if (await _appointmentRepository.SaveChangeAsync())
                {
                    return Ok("Appointment added");
                }
                return BadRequest("Appointment was not saved");
            }
            return BadRequest("Invalid Data");
        }

        [HttpPut("(Id)")]
        public async Task<IActionResult> Put(int id, AppointmentUpdateDto appointment)
        {
            if (id > 0)
            {
                var appointmentDatabase = await _appointmentRepository.GetByIdAsync(id);
                
                if (appointment.ProfessionalId == null || appointment.PatientId == null || appointment.SpecialtyId == null)
                {
                    appointment.ProfessionalId = appointmentDatabase.ProfessionalId;
                    appointment.PatientId = appointmentDatabase.PatientId;
                    appointment.SpecialtyId = appointmentDatabase.SpecialtyId;
                }

                var result = _mapper.Map(appointment, appointmentDatabase);
                

                _appointmentRepository.Update(result);

                if (await _appointmentRepository.SaveChangeAsync())
                {
                    return Ok("Appointment updated");
                }
                return BadRequest("Appointment was not update");
            }
            return BadRequest("Invalid Id");
        }

        [HttpDelete("(Id)")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var result = await _appointmentRepository.GetByIdAsync(id);


                if (result != null)
                {
                    _appointmentRepository.Delete(result);
                    await _appointmentRepository.SaveChangeAsync();
                    return Ok("Appointment deleted");
                }
                return NotFound("Appointment not found");

            }
            return BadRequest("Invalid Id");
        }
    }
}
