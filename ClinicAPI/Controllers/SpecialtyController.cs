using AutoMapper;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly IMapper _mapper;
        public SpecialtyController(ISpecialtyRepository specialtyRepository, IMapper mapper)
        {
            _specialtyRepository = specialtyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _specialtyRepository.GetAllSpecialitiesAsync();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("Specialities not found");
        }

        [HttpGet("(Id)")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id > 0)
            {
                var specialty = await _specialtyRepository.GetByIdAsync(id);
                var result = _mapper.Map<SpecialtyDetailsDto>(specialty);

                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound("Specialty not found");
            }
            return BadRequest("Invalid Id");
        }

        [HttpPost]
        public async Task<IActionResult> Post(SpecialtyAddDto specialty)
        {
            if (!string.IsNullOrEmpty(specialty.Name))
            {
                var result = _mapper.Map<Specialty>(specialty);
                _specialtyRepository.Update(result);
                
                if (await _specialtyRepository.SaveChangeAsync())
                {
                    return Ok("Specialty added");
                }
                return BadRequest("Specialty was not saved");
            }
            return BadRequest("Invalid Data");
        }

        [HttpPut("(Id)")]
        public async Task<IActionResult> Put(int id, SpecialtyUpdateDto specialty)
        {
            if (id > 0)
            {
                var specialtyDatabase = await _specialtyRepository.GetByIdAsync(id);
                var result = _mapper.Map(specialty, specialtyDatabase);
                _specialtyRepository.Update(result);

                if (await _specialtyRepository.SaveChangeAsync())
                {
                    return Ok("Specialty updated");
                }
                return BadRequest("Specialty was not updated");
            }
            return BadRequest("Invalid Id");
        }

        [HttpDelete("(Id)")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
