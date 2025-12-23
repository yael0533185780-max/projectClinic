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
        public IEnumerable<Queues> GetAllQueues();
        public Queues GetQueueById(int id);
        public void DeleteQueueById(int id);
        public void AddQueue(Queues queue);
        public void UpdateQueue(Queues queue, int id);
        public Queues GetQueuesByDate(DateTime date,int doctorId);
    }
}
