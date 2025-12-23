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
        public IEnumerable<ClientDTO> Get()
        {

            var cList = _clientService.GetAllClients();
            var cDTOList = new List<ClientDTO>();
            cDTOList = _mapper.Map<List<ClientDTO>>(cList);
            return cDTOList;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var client = _clientService.GetClientById(id);
            var c = _mapper.Map<ClientDTO>(client);

            if (client == null)
                return NotFound();
            return Ok(c);
        }

        // POST api/<ClientsController>
        [HttpPost]
        public ActionResult Post([FromBody] ClientsPostModel value)
        {
            var c=new Clients {Name=value.Name,Phone=value.Phone,Email=value.Email,City=value.City,Address=value.Address };
              var clients = _clientService.GetClientByEmail(value.Email);
            if (clients == null)
            {
                _clientService.AddClient(c);
                 return Ok(c);
            }
             return Conflict();
        }
        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClientsPostModel value)
        {
            var c = new Clients { Name = value.Name, Phone = value.Phone, Email = value.Email, City = value.City, Address = value.Address };
            var clients = _clientService.GetClientByEmail(value.Email);
            if (clients == null)
            {
                return BadRequest();
            }
            _clientService.UpdateClient(c,id);
            return Ok(c);
        }
        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var c = _clientService.GetClientById( id);
            if (c == null)
            {
                return BadRequest();
            }
           _clientService.DeleteClient(id);
            return NoContent();
        }

    }
}
