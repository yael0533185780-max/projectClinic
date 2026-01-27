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
//    public class DoctorControllerTest

//    {
//        private FakeContext fakeContext = new FakeContext();

//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new DoctorsController(fakeContext);
//            var result = controller.Get();
//            Assert.IsType<List<Doctors>>(result);
//        }
//        [Fact]
//        public void Get_DoctorbyId()
//        {
//            var id = 3;
//            var controller = new DoctorsController(fakeContext);
//            var result = controller.Get(id);

//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Post_AddDoctor()
//        {

//            var controller = new DoctorsController(fakeContext);
//            Doctors newc = new Doctors { Id = 2, Name = "dfe",Phone="055325643",Email="fh",Businesshours=8 };
//            var result = controller.Post(newc);

//            Assert.IsType<OkObjectResult>(result);

//        }

//        [Fact]
//        public void Put_Doctor()
//        {
//            var id = 3;
//            Doctors f = new Doctors { Id = 3, Name = "gj", Phone = "0554323476", Email = "fdhh", Businesshours=9 };
//            var controller = new DoctorsController(fakeContext);
//            var result = controller.Put(id, f);
//            Assert.IsType<OkObjectResult>(result);
//        }

//        [Fact]
//        public void Delete_Doctor()
//        {
//            var id = 3;
//            var controller = new DoctorsController(fakeContext);
//            var result = controller.Delete(id);
//            Assert.IsType<NoContentResult>(result);

//        }
//    }
//}
