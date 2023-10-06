using AutoMapper;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessionalController : ControllerBase
    {
        private readonly IProfessionalRepository _professionalRepository;
        private readonly IMapper _mapper;

        public ProfessionalController(IProfessionalRepository professionalRepository, IMapper mapper)
        {
            _professionalRepository = professionalRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _professionalRepository.GetAllProfessionalsAsync();

            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("Professionals not found");
        }

        [HttpGet("(Id)")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id > 0)
            {
                var professional = await _professionalRepository.GetByIdAsync(id);

                var result = _mapper.Map<ProfessionalDetailsDto>(professional);

                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound("Professional not found");
            }
            return BadRequest("Invalid Id");
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProfessionalAddDto professional)
        {
            if (!string.IsNullOrEmpty(professional.Name))
            {
                var result = _mapper.Map<Professional>(professional);
                _professionalRepository.Add(result);

                if (await _professionalRepository.SaveChangeAsync())
                {
                    return Ok("Professional added");
                }
                return BadRequest("Professional was not saved");
            }
            return BadRequest("Invalid Data");
        }

        [HttpPut("(Id)")]
        public async Task<IActionResult> Put(int id, ProfessionalUpdateDto professional)
        {
            if (id > 0)
            {
                var professionalDatabase = await _professionalRepository.GetByIdAsync(id);
                var result = _mapper.Map(professional, professionalDatabase);
                _professionalRepository.Update(result);

                if (await _professionalRepository.SaveChangeAsync())
                {
                    return Ok("Professional updated");
                }
                return BadRequest("Professional was not updated");
            }
            return NotFound("Professional not found");
        }

        [HttpDelete("(Id)")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var result = await _professionalRepository.GetByIdAsync(id);

                if(result != null)
                {
                    _professionalRepository.Delete(result);
                    await _professionalRepository.SaveChangeAsync();

                    return Ok("Professional deleted");
                }
                return NotFound("Professional not found");
            }
            return BadRequest("Invalid Id");
        }
    }
}
