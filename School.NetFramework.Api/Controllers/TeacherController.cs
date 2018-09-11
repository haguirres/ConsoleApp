using System;
using System.Collections.Generic;
using School.NetFramework.Bussiness;

using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using School.Entities.DTOs;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [Route("api/teachers")]
    public class TeacherController : ApiController
    {

        TeacherABC teacherABC;
        public TeacherController()
        {
            teacherABC = new TeacherABC();
        }

        [HttpGet, Route("tachers")]
        [ResponseType(typeof(List<TeacherDto>))]
        public HttpResponseMessage GetTeachers()
        {
            var teacherList = teacherABC.GetTeachers();
            return Request.CreateResponse(HttpStatusCode.OK, teacherList);
        }

        [HttpGet, Route("teacher/{id}")]
        [ResponseType(typeof(TeacherDto))]
        public HttpResponseMessage GetTeacher(int id)
        {
            var teacher = teacherABC.GetTeacher(id);
            return Request.CreateResponse(HttpStatusCode.OK, teacher);

        }

        [HttpPost, Route("teacher/")]
        [ResponseType(typeof(TeacherDto))]
        public HttpResponseMessage CreateTeacher(TeacherDto teacher)
        {
            //Inserta presona
            var newTeacher = teacherABC.InsertNewTeacher(teacher);
            return Request.CreateResponse(HttpStatusCode.OK, newTeacher);
        }

        [HttpPut, Route("teacher/{id}")]
        [ResponseType(typeof(TeacherDto))]
        public HttpResponseMessage UpdateTeacher(TeacherDto teacherDto)
        {
            teacherABC.UpdateTeacher(teacherDto);
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpDelete, Route("teacher/{id}")]
        public HttpResponseMessage DeleteTeacher(int id)
        {
            var teacher = teacherABC.GetTeacher(id);
            teacherABC.DeleteTeacher(teacher);
            return Request.CreateResponse(HttpStatusCode.OK);

        }
    }
}
