//using Microsoft.AspNetCore.Mvc;
//using projectClinic.Controllers;
//using projectClinic.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestClinic
//{
//    public class QueueControllerTest
//    {
//        private FakeContext fakeContext = new FakeContext();

//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new QueuesController(fakeContext);
//            var result = controller.Get();

//            Assert.IsType<List<Queues>>(result);
//        }
//        [Fact]
//        public void Get_QueuebyId()
//        {
//            var id = 5;
//            var controller = new QueuesController(fakeContext);
//            var result = controller.Get(id);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Post_AddQueue()
//        {

//            var controller = new QueuesController(fakeContext);
//            Queues newq = new Queues { Id = 2};
//            var result = controller.Post(newq);

//            Assert.IsType<OkObjectResult>(result);

//        }
//        [Fact]
//        public void Put_Queue()
//        {
//            var id = 5;
//            Queues f = new Queues { Id = 3, };
//            var controller = new QueuesController(fakeContext);
//            var result = controller.Put(id, f);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Delete_Queue()
//        {
//            var id = 5;
//            var controller = new QueuesController(fakeContext);
//            var result = controller.Delete(id);
//            Assert.IsType<NoContentResult>(result);

//        }
//    }
//}
