using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Clinic.Core.Repositories;
namespace Clinic.Service
{
    public class QueueService:IQueueService
    {
        private readonly IQueuesRepository _queuesRepository;

        public QueueService(IQueuesRepository clientsRepository)
        {
            _queuesRepository = clientsRepository;
        }
        public IEnumerable<Queues> GetAllQueues()
        {
            return _queuesRepository.GetAllQueues();
        }
        public Queues GetQueueById(int id)
        {
            return _queuesRepository.GetQueueById(id);
        }
        public void DeleteQueueById(int id)
        {
            _queuesRepository.DeleteQueueById(id);
             _queuesRepository.Save();
        }
        public void AddQueue(Queues queue)
        {
            _queuesRepository.AddQueue(queue);
            _queuesRepository.Save();
        }
        public void UpdateQueue(Queues queue, int id)
        {
            _queuesRepository.UpdateQueue(queue, id);
            _queuesRepository.Save();
        }
        public Queues GetQueuesByDate(DateTime date, int doctorId)
        {
            return _queuesRepository.GetQueuesByDate(date, doctorId);
        }

    }
}
