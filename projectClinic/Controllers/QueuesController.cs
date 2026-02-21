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
    public class QueuesController : ControllerBase
    {
        private readonly IQueueService _queueService;
        private readonly IMapper _mapper;

        public QueuesController(IQueueService queueService, IMapper mapper)
        {
            _queueService = queueService;
            _mapper = mapper;
        }
        [Authorize]

        // GET: api/<QueuesController>
        [HttpGet]
        public async Task<List<QueueDTO>> Get()
        {
            var qList =await _queueService.GetAllQueuesAsync();
            var qDTOList = new List<QueueDTO>();
            qDTOList = _mapper.Map<List<QueueDTO>>(qList);
            return qDTOList;
        }

        // GET api/<QueuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var q =await _queueService.GetQueueByIdAsync(id);
            var queue= _mapper.Map<QueueDTO>(q);
            if (q == null)
                return NotFound();
            return Ok(queue);
        }
        [Authorize]
        // POST api/<QueuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] QueuePostModel value)
        {
            var q = _mapper.Map<Queues>(value);
            var queue =await _queueService.GetQueuesByDateAsync(value.Date, value.DoctorId);
            if (queue == null)
            {
                _queueService.AddQueueAsync(q);
                return Ok(q);
            }
            return Conflict();
        }
        [Authorize]

        // PUT api/<QueuesController>/5
        [HttpPut("{date},{doctorId}")]
        public async Task<ActionResult> Put(DateTime date,int doctorId, [FromBody] QueuePostModel value)
        {
            var queue = _mapper.Map<Queues>(value); ;

            var q =await _queueService.GetQueuesByDateAsync(date, doctorId);
            if (q == null)
            {
                return BadRequest();
            }
            await _queueService.UpdateQueueAsync(queue, q.Id);
            return Ok(queue);
        }

        // DELETE api/<QueuesController>/5


        [Authorize]

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var q =await _queueService.GetQueueByIdAsync(id);
            if (q == null)
            {
                return BadRequest();
            }
           await _queueService.DeleteQueueByIdAsync(id);
            return NoContent();
        }
    }
}
