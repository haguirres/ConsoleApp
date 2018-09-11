using System.Collections.Generic;
using School.NetFramework.Bussiness;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using School.Entities.DTOs;
using System.Web.Http.Description;



namespace School.NetFramework.Api.Controllers
{
    public class CourseController : ApiController
    {
        ProcessCourse ProcessCourse;
        public CourseController()
        {
            ProcessCourse = new ProcessCourse();
        }

        [HttpGet, Route("Course")]
        [ResponseType(typeof(List<CourseDto>))]
        public HttpResponseMessage GetCourses()
        {
            var CourseList = ProcessCourse.GetCourse();
            return Request.CreateResponse(HttpStatusCode.OK, CourseList);
        }

        [HttpGet, Route("Course/{id}")]
        [ResponseType(typeof(CourseDto))]
        public HttpResponseMessage Course(int StudentId, string SchoolId)
        {
            var Course = ProcessCourse.GetCourse();
            return Request.CreateResponse(HttpStatusCode.OK, Course);
        }

        [HttpPost, Route("Course")]
        [ResponseType(typeof(CourseDto))]
        public HttpResponseMessage InsertCourse(CourseDto Course)
        {
            var InsertInsc = ProcessCourse.InsertCourse(Course);
            return Request.CreateResponse(HttpStatusCode.OK, InsertInsc);
        }

        [HttpPost, Route("Course")]
        [ResponseType(typeof(CourseDto))]
        public HttpResponseMessage UpdateCourse(CourseDto Course)
        {
            ProcessCourse.UpdateCourse(Course);
            return Request.CreateResponse(HttpStatusCode.OK);
        } 

        [HttpPost, Route("Course")]
        [ResponseType(typeof(CourseDto))]
        public HttpResponseMessage DeleteCourse(CourseDto Course)
        {
            ProcessCourse.UpdateCourse(Course);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
