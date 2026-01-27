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

        public QueueService(IQueuesRepository ququesRepository)
        {
            _queuesRepository = ququesRepository;
        }
        public async Task<List<Queues>> GetAllQueuesAsync()
        {
            return await _queuesRepository.GetAllQueuesAsync();
        }
        public async Task<Queues> GetQueueByIdAsync(int id)
        {
            return await _queuesRepository.GetQueueByIdAsync(id);
        }
        public async Task DeleteQueueByIdAsync(int id)
        {
           await _queuesRepository.DeleteQueueByIdAsync(id);
           await  _queuesRepository.SaveAsync();
        }
        public async Task AddQueueAsync(Queues queue)
        {
           await _queuesRepository.AddQueueAsync(queue);
           await _queuesRepository.SaveAsync();
        }
        public async Task UpdateQueueAsync(Queues queue, int id)
        {
           await _queuesRepository.UpdateQueueAsync(queue, id);
           await _queuesRepository.SaveAsync();
        }
        public async Task<Queues> GetQueuesByDateAsync(DateTime date, int doctorId)
        {
            return await _queuesRepository.GetQueuesByDateAsync(date, doctorId);
        }

    }
}
