//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using School.Entities.DTOs;
//using School.NetFramework.Bussiness;
//using System.Web.Http.Description;

//namespace School.NetFramework.Api.Controllers
//{
//    public class CourseController : ApiController
//    {
//        ProcessCourse ProcessCourse;
//        public CourseController()
//        {
//            ProcessCourse = new ProcessCourse();
//        }

//        [HttpGet, Route("Course")]
//        [ResponseType(typeof(List<CourseDto>))]
//        public HttpResponseMessage GetCourses()
//        {
//            var CourseList = ProcessCourse.GetCourse();
//            return Request.CreateResponse(HttpStatusCode.OK, CourseList);
//        }

//        [HttpGet, Route("Course/{id}")]
//        [ResponseType(typeof(CourseDto))]
//        public HttpResponseMessage GetInscriptions(int StudentId, string SchoolId)
//        {
//            var inscription = ProcessInscription.GetInscription(StudentId, SchoolId);
//            return Request.CreateResponse(HttpStatusCode.OK, inscription);
//        }

//        [HttpPost, Route("inscription")]
//        [ResponseType(typeof(InscriptionDto))]
//        public HttpResponseMessage InsertInscription(InscriptionDto inscription)
//        {
//            var InsertInsc = ProcessInscription.InsertInscription(inscription);
//            return Request.CreateResponse(HttpStatusCode.OK, InsertInsc);
//        }

//        [HttpPost, Route("inscription")]
//        [ResponseType(typeof(InscriptionDto))]
//        public HttpResponseMessage UpdateInscription(InscriptionDto inscription)
//        {
//            ProcessInscription.UpdateInscription(inscription);
//            return Request.CreateResponse(HttpStatusCode.OK);
//        }

//        [HttpPost, Route("inscription")]
//        [ResponseType(typeof(InscriptionDto))]
//        public HttpResponseMessage DeleteInscription(InscriptionDto inscription)
//        {
//            ProcessInscription.UpdateInscription(inscription);
//            return Request.CreateResponse(HttpStatusCode.OK);
//        }
//    }
//}
