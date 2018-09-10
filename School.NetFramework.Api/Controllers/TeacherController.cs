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

    }
}
