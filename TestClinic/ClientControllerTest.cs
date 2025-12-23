//using Microsoft.AspNetCore.Components.Forms;
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
//    public class ClientControllerTest
//    {
//        private FakeContext fakeContext = new FakeContext();

//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new ClientsController(fakeContext);
//            var result = controller.Get();

//            Assert.IsType<List<Clients>>(result);
//        }
//        [Fact]
//        public void Get_ReturnClientbyId()
//        {
//            var id = 4;
//            var controller = new ClientsController(fakeContext);
//            var result = controller.Get(id);

//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Post_AddClient()
//        {

//            var controller = new ClientsController(fakeContext);
//            Clients newc = new Clients { Id = 2, Name = "dfe" };
//            var result = controller.Post(newc);

//            Assert.IsType<OkObjectResult>(result);

//        }
//        [Fact]
//        public void Put_Client()
//        {
//            var id = 4;
//            Clients f = new Clients { Id = 3, Name = "gj", Phone = "0554323476", Email = "fdhh", City = "ter", Address = "yerytr" };
//            var controller = new ClientsController(fakeContext);
//            var result = controller.Put(id, f);
//            Assert.IsType<OkObjectResult>(result);
//        }

//        [Fact]
//        public void Delete_Client()
//        {
//            var id = 4;
//            var controller = new ClientsController(fakeContext);
//            var result = controller.Delete(id);
//            Assert.IsType<NoContentResult>(result);

//        }


//    }


//}
