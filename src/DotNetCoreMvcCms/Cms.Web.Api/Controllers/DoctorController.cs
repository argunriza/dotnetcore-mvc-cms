﻿using AutoMapper;
using Cms.Data.Models.Entities;
using Cms.Services.Abstract;
using Cms.Web.Api.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Cms.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorController(IMapper mapper, IDoctorService doctorService)
        {
            _mapper        = mapper;
            _doctorService = doctorService;
        }

        // GET: api/Doctors
        [HttpGet]
        public IEnumerable<DoctorEntity> GetAll()
        {
            var doctors = _doctorService.GetAll();

            return doctors;
        }

        // GET: api/Doctors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var doctor = await _doctorService.GetByIdAsync(id);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] DoctorCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var mapp   = _mapper.Map<DoctorEntity>(dto);
                var doctor = await _doctorService.AddAsync(mapp);

                return Ok(doctor);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // PUT: api/Doctors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] DoctorUpdateDto dto)
        {
            if (dto.Id != id)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var mapp   = _mapper.Map<DoctorEntity>(dto);
                var doctor = await _doctorService.UpdateAsync(id, mapp);

                return Ok(doctor);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var isDeleted = await _doctorService.DeleteAsync(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
