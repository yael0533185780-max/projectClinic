using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Service;
using projectClinic.Models;
using AutoMapper;
using Clinic.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<DoctorDTO> Get()
        {
            var dList=_doctorService.GetAllDoctors();
            var dDTOList = new List<DoctorDTO>();
            dDTOList = _mapper.Map<List<DoctorDTO>>(dList);
            return dDTOList;
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var d = _doctorService.GetDoctorById(id);
            var doctor = _mapper.Map<DoctorDTO>(d);

            if (d == null)
                return NotFound();
            return Ok(doctor);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public ActionResult Post([FromBody] DoctorsPostModel value)
        {
            var doctor = new Doctors { Name = value.Name, Phone = value.Phone, Email = value.Email, Businesshours = value.Businesshours };

            var d = _doctorService.GetDoctorsByEmail(value.Email);
            if (d == null)
            {
                _doctorService.AddDoctor(doctor);
                return Ok(doctor);
            }
            return Conflict();
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DoctorsPostModel value)
        {
            var doctor = new Doctors { Name = value.Name, Phone = value.Phone, Email = value.Email, Businesshours = value.Businesshours };

            var d = _doctorService.GetDoctorsByEmail(value.Email);
            if (d == null)
            {
                return BadRequest();
            }
            _doctorService.UpdateDoctors(doctor, id);
            return Ok(doctor);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var d = _doctorService.GetDoctorById(id);
            if (d == null)
            {
                return BadRequest();
            }
            _doctorService.DeleteDoctor(id);
            return NoContent();
        }
    }
}
