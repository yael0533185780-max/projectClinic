using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Repositories;
using Clinic.Core.Entities;
using System.Collections;
//using projectClinic;

namespace Clinic.Data.Repositories
{
    public class QueueRepository: IQueuesRepository
    {
        private readonly DataContext _context;

        public QueueRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Queues> GetAllQueues()
        {
            return _context.queues;
        }
        public Queues GetQueueById(int id)
        {
            return _context.queues.ToList().Find(x => x.Id == id);
        }
        public void AddQueue(Queues q)
        {
            _context.queues.Add(q);
        }
        public void UpdateQueue(Queues q, int id)
        {
            var c = _context.queues.ToList().Find(c => c.Id == id);
                c.Date=q.Date;
                c.Starttime=q.Starttime;
                c.Endtime=q.Endtime;
                c.DoctorId=q.DoctorId;
                c.ClientId=q.ClientId;
            
        }
        public void DeleteQueueById(int id)
        {
            var c = _context.queues.ToList().Find(c => c.Id == id);
                _context.queues.Remove(c);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public Queues GetQueuesByDate(DateTime date, int doctorId)
        {
            return _context.queues.ToList().Find(q => (q.Date == date && q.DoctorId == doctorId));
        }

    }
}
