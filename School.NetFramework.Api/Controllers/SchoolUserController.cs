using School.Entities.DTOs;
using School.NetFramework.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [RoutePrefix("api")]
    [EnableCors("*", "*", "*")]
    [Route("api/school-user")]
    public class SchoolUserController : ApiController
    {

        ProcessSchoolUser processSchoolUser;
        public SchoolUserController()
        {
            processSchoolUser = new ProcessSchoolUser();
        }


        [HttpGet, Route("school-user")]
        [ResponseType(typeof(List<SchoolUserDto>))]
        public HttpResponseMessage GetUsers()
        {
            var usersList = processSchoolUser.GetUsers();
            return Request.CreateResponse(HttpStatusCode.OK, usersList);
        }

        [HttpGet, Route("school-user/{id}")]
        [ResponseType(typeof(SchoolUserDto))]
        public HttpResponseMessage GetUsers(int id)
        {
            var user = processSchoolUser.GetUser(id);
            return Request.CreateResponse(HttpStatusCode.OK, user);

        }

        [HttpPost, Route("school-user/")]
        [ResponseType(typeof(TeacherDto))]
        public HttpResponseMessage CreateUser(SchoolUserDto userDto)
        {
            var newUser = processSchoolUser.InsertNewUser(userDto);
            return Request.CreateResponse(HttpStatusCode.OK, newUser);
        }

        [HttpPut, Route("school-user/{id}")]
        [ResponseType(typeof(SchoolUserDto))]
        public HttpResponseMessage UpdateUser(SchoolUserDto userDto)
        {
            processSchoolUser.UpdateUser(userDto);
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpDelete, Route("school-user/{id}")]
        public HttpResponseMessage DeleteUser(int id)
        {
            var user = processSchoolUser.GetUser(id);
            processSchoolUser.DeleteUser(user);
            return Request.CreateResponse(HttpStatusCode.OK);

        }
    }
}