using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApp.Controllers
{
   
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            Student student = new Student { Id = 1, Name = "ABC" };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, student);
            return response;
        }
    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
