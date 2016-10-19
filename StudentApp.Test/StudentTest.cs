using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentApp.Controllers;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http;
using System.Threading.Tasks;

namespace StudentApp.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void GetStudent_ShouldReturn_Student()
        {
            //Arrange
            StudentController studentController = new StudentController();

            studentController.Request = new HttpRequestMessage()
            {
                Properties = { { HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration() } }
            };


            //Act
            var response = studentController.Get();
            Student student;
            Assert.IsTrue(response.TryGetContentValue<Student>(out student));

            //Assert
            Assert.AreEqual(1, student.Id);
        }
    }
}
