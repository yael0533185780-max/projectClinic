using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Repositories;
using Clinic.Core.Entities;
using System.Collections;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<Queues>> GetAllQueuesAsync()
        {
            return await _context.queues.ToListAsync();
        }
        public async Task<Queues> GetQueueByIdAsync(int id)
        {
            return await _context.queues.FirstAsync(x => x.Id == id);
        }
        public async Task AddQueueAsync(Queues q)
        {
            _context.queues.Add(q);
        }
        public async Task UpdateQueueAsync(Queues q, int id)
        {
            var c = await _context.queues.FirstAsync(c => c.Id == id);
                c.Date=q.Date;
                c.Starttime=q.Starttime;
                c.Endtime=q.Endtime;
                c.DoctorId=q.DoctorId;
                c.ClientId=q.ClientId;
            
        }
        public async Task DeleteQueueByIdAsync(int id)
        {
            var c = await _context.queues.FirstAsync(c => c.Id == id);
             _context.queues.Remove(c);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<Queues> GetQueuesByDateAsync(DateTime date, int doctorId)
        {
            return await _context.queues.FirstOrDefaultAsync(q => (q.Date == date && q.DoctorId == doctorId));
        }

    }
}
