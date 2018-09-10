using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using School.NetFramework.Bussiness;
using School.Entities.DTOs;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [Route("api/students")]
    public class StudentController : ApiController
    {
        ProcessStudent studenP;
        public StudentController() => studentP = new ProcessStudent();

        [HttpGet, Route("students")]
        [ResponseType(typeof(List<StudentDto>))]
        public HttpResponseMessage GetStudents()
        {
            var studentList = studentP.GetStudents();
            return Request.CreateResponse(HttpStatusCode.OK, studentList);
        }
    }
}
