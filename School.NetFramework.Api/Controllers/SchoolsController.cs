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


    }
}
