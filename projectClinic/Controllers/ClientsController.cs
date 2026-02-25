using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using projectClinic.Models;
using AutoMapper;
using Clinic.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Clinic.Service;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly IMapper _mapper;

        private readonly IClientService _clientService;
        private readonly IUserService _userService;

        public ClientsController(IClientService clientService, IMapper mapper,IUserService userService)
        {
            _clientService = clientService;
            _userService=userService;
            _mapper = mapper;
        }
        [Authorize]
        [HttpGet]
        public async Task<List<ClientDTO>> Get()
        {

            var cList =await _clientService.GetAllClientsAsync();
            var cDTOList = new List<ClientDTO>();
            cDTOList = _mapper.Map<List<ClientDTO>>(cList);
            return cDTOList;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            var c = _mapper.Map<ClientDTO>(client);

            if (client == null)
                return NotFound();
            return Ok(c);
        }

        // POST api/<ClientsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClientsPostModel value)
        {
            var user = new User { UserName = value.Name, Password = value.password, Role = eRole.client };
            var User = await _userService.AddUserAsync(user);
            var c = _mapper.Map<Clients>(value); 
            var clients = await _clientService.GetClientByEmailAsync(value.Email);
            if (clients == null)
            {
                await _clientService.AddClientAsync(c);
                 return Ok(c);
            }
             return Conflict();
        }
        // PUT api/<ClientsController>/5
        [Authorize]

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(int id, [FromBody] ClientsPostModel value)
        {
            var c = _mapper.Map<Clients>(value); ;
            var clients = await _clientService.GetClientByIdAsync(id);
            if (clients == null)
            {
                return BadRequest();
            }
            await _clientService.UpdateClientAsync(c,id);
            return Ok(c);
        }
        // DELETE api/<ClientsController>/5
        [Authorize]
        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var c = await _clientService.GetClientByIdAsync( id);
            if (c == null)
            {
                return BadRequest();
            }
            await _clientService.DeleteClientAsync(id);
            return NoContent();
        }

    }
}
