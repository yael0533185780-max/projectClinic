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
    public class QueuesController : ControllerBase
    {
        private readonly IQueueService _queueService;
        private readonly IMapper _mapper;

        public QueuesController(IQueueService queueService, IMapper mapper)
        {
            _queueService = queueService;
            _mapper = mapper;
        }
        // GET: api/<QueuesController>
        [HttpGet]
        public IEnumerable<QueueDTO> Get()
        {
            var qList = _queueService.GetAllQueues();
            var qDTOList = new List<QueueDTO>();
            qDTOList = _mapper.Map<List<QueueDTO>>(qList);
            return qDTOList;
        }

        // GET api/<QueuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var q = _queueService.GetQueueById(id);
            var queue= _mapper.Map<QueueDTO>(q);
            if (q == null)
                return NotFound();
            return Ok(queue);
        }

        // POST api/<QueuesController>
        [HttpPost]
        public ActionResult Post([FromBody] QueuePostModel value)
        {
            var q = new Queues { Date = value.Date,Starttime=value.Starttime,Endtime=value.Endtime,DoctorId=value.DoctorId,ClientId=value.ClientId };
            var queue = _queueService.GetQueuesByDate(value.Date, value.DoctorId);
            if (queue == null)
            {
                _queueService.AddQueue(q);
                return Ok(q);
            }
            return Conflict();
        }

        // PUT api/<QueuesController>/5
        [HttpPut("{date},{doctorId}")]
        public ActionResult Put(DateTime date,int doctorId, [FromBody] QueuePostModel value)
        {
            var queue = new Queues { Date = value.Date, Starttime = value.Starttime, Endtime = value.Endtime, DoctorId = value.DoctorId, ClientId = value.ClientId };

            var q = _queueService.GetQueuesByDate(value.Date, value.DoctorId);
            if (q == null)
            {
                return BadRequest();
            }
            _queueService.UpdateQueue(queue, q.Id);
            return Ok(queue);
        }

        // DELETE api/<QueuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var q = _queueService.GetQueueById(id);
            if (q == null)
            {
                return BadRequest();
            }
            _queueService.DeleteQueueById(id);
            return NoContent();
        }
    }
}
