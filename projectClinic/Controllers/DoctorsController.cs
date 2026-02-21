using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Service;
using projectClinic.Models;
using AutoMapper;
using Clinic.Core.DTOs;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public DoctorsController(IDoctorService doctorService, IMapper mapper, IUserService userService)
        {
            _doctorService = doctorService;
            _mapper = mapper;
            _userService = userService;
        }
        [Authorize]

        [HttpGet]
        public async Task<List<DoctorDTO>> Get()
        {
            var dList=await _doctorService.GetAllDoctorsAsync();
            var dDTOList = new List<DoctorDTO>();
            dDTOList = _mapper.Map<List<DoctorDTO>>(dList);
            return dDTOList;
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var d =await _doctorService.GetDoctorByIdAsync(id);
            var doctor = _mapper.Map<DoctorDTO>(d);

            if (d == null)
                return NotFound();
            return Ok(doctor);
        }

        // POST api/<DoctorsController>
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DoctorsPostModel value)
        {

            var user = new User { UserName = value.Name, Password = value.password, Role = eRole.doctor };
            var User = await _userService.AddUserAsync(user);
            var doctor = _mapper.Map<Doctors>(value); 

            var d =await _doctorService.GetDoctorByEmailAsync(value.Email);
            if (d == null)
            {
               await _doctorService.AddDoctorAsync(doctor);
                return Ok(doctor);
            }
            return Conflict();
        }

        // PUT api/<DoctorsController>/5
        [Authorize]

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DoctorsPostModel value)
        {
            var doctor = _mapper.Map<Doctors>(value); ;

            var d =await _doctorService.GetDoctorByIdAsync(id);
            if (d == null)
            {
                return BadRequest();
            }
          await  _doctorService.UpdateDoctorsAsync(doctor, id);
            return Ok(doctor);
        }

        // DELETE api/<DoctorsController>/5
        [Authorize]

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var d =await _doctorService.GetDoctorByIdAsync(id);
            if (d == null)
            {
                return BadRequest();
            }
          await  _doctorService.DeleteDoctorAsync(id);
            return NoContent();
        }
    }
}
