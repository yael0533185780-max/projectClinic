using Microsoft.AspNetCore.Mvc;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using projectClinic.Models;
using AutoMapper;
using Clinic.Core.DTOs;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly IMapper _mapper;

        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

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
            var c=new Clients {Name=value.Name,Phone=value.Phone,Email=value.Email,City=value.City,Address=value.Address };
            var clients = await _clientService.GetClientByEmailAsync(value.Email);
            if (clients == null)
            {
                await _clientService.AddClientAsync(c);
                 return Ok(c);
            }
             return Conflict();
        }
        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClientsPostModel value)
        {
            var c = new Clients { Name = value.Name, Phone = value.Phone, Email = value.Email, City = value.City, Address = value.Address };
            var clients = await _clientService.GetClientByIdAsync(id);
            if (clients == null)
            {
                return BadRequest();
            }
            await _clientService.UpdateClientAsync(c,id);
            return Ok(c);
        }
        // DELETE api/<ClientsController>/5
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
