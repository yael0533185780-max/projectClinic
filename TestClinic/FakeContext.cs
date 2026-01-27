//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using projectClinic;
//using projectClinic.Entities;

//namespace TestClinic
//{
   
//    public class FakeContext: IDataContext
//    {

//        public List<Clients> clients { get; set; }

//        public List<Doctors> doctors { get; set; }

//        public List<Queues> queues { get; set; }
//        public FakeContext()
//        {
//            clients = new List<Clients> { new Clients { Id = 4, Name = "gfhj", Phone = "05523476", Email = "fdhjhklh", City = "thkler", Address = "yehkrytr" } };
//            doctors = new List<Doctors> { new Doctors { Id = 3, Name = "hkh", Phone = "055645634", Email = "ewege@yumj", Businesshours = 6 } };
//            queues = new List<Queues> { new Queues { Id = 5, Date = new DateTime(), Starttime = new DateTime(), Endtime = new DateTime(), DoctorId = 3, ClientId = 3 } };
//        }
//    }
//}
