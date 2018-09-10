using School.Entities.DTOs;
using School.NetFramework.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [Route("api/schools")]
    public class SchoolsController : ApiController
    {
        ProcessSchools processSchools;

        public SchoolsController()
        {
            processSchools = new ProcessSchools();
        }

        [HttpGet, Route("schools")]
        [ResponseType(typeof(List<SchoolDto>))]
        public HttpResponseMessage GetSchools()
        {
            var schoolList = processSchools.GetSchools();
            return Request.CreateResponse(HttpStatusCode.OK, schoolList);
        }

        [HttpGet, Route("schools/{id}")]
        [ResponseType(typeof(SchoolDto))]
        public HttpResponseMessage GetSchools(string id)
        {
            var school = processSchools.GetSchool(id);
            return Request.CreateResponse(HttpStatusCode.OK, school);

        }

        [HttpPost, Route("schools")]
        [ResponseType(typeof(SchoolDto))]
        public HttpResponseMessage PostSchool(SchoolDto schoolDto)
        {
            string school = processSchools.InsertNewSchool(schoolDto);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut, Route("schools")]
        [ResponseType(typeof(SchoolDto))]
        public HttpResponseMessage PutSchool(SchoolDto schoolDto)
        {
            processSchools.UpdateSchool(schoolDto);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete, Route("schools/{id}")]
        [ResponseType(typeof(SchoolDto))]
        public HttpResponseMessage DeleteSchool(string id)
        {
            processSchools.DeleteSchool(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
