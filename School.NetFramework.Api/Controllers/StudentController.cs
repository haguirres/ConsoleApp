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
        ProcessStudent studentP;
        public StudentController() => studentP = new ProcessStudent();

        [HttpGet, Route("students")]
        [ResponseType(typeof(List<StudentDto>))]
        public HttpResponseMessage GetStudents()
        {
            var studentList = studentP.GetStudents();
            return Request.CreateResponse(HttpStatusCode.OK, studentList);
        }

        [HttpGet, Route("student/{id}")]
        [ResponseType(typeof(StudentDto))]
        public HttpResponseMessage GetStudent(int id)
        {
            var student = studentP.GetStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, student);

        }

        [HttpPost, Route("student/")]
        [ResponseType(typeof(StudentDto))]
        public HttpResponseMessage CreateStudent(StudentDto student)
        {
            var newStudent = studentP.InsertNewStudent(student);
            return Request.CreateResponse(HttpStatusCode.OK, newStudent);
        }

        [HttpPut, Route("student/{id}")]
        [ResponseType(typeof(StudentDto))]
        public HttpResponseMessage UpdateStudent(StudentDto studentDto)
        {
            studentP.UpdateStudent(studentDto);
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpDelete, Route("student/{id}")]
        public HttpResponseMessage DeleteStudent(int id)
        {
            var student = studentP.GetStudent(id);
            studentP.DeleteStudent(student);
            return Request.CreateResponse(HttpStatusCode.OK);

        }
    }
}

