using Clinic.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IQueueService
    {
        public Task<List<Queues>> GetAllQueuesAsync();
        public Task<Queues> GetQueueByIdAsync(int id);
        public Task DeleteQueueByIdAsync(int id);
        public Task AddQueueAsync(Queues queue);
        public Task UpdateQueueAsync(Queues queue, int id);
        public Task<Queues> GetQueuesByDateAsync(DateTime date,int doctorId);
    }
}
