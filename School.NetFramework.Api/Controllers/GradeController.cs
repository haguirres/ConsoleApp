using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Description;
using School.Entities.DTOs;
using School.NetFramework.Bussiness;

namespace School.NetFramework.Api.Controllers
{
    [Route("api/Grade")]
    public class GradeController : ApiController
    {
            ProcessGrade gradeP;
            public GradeController() => gradeP = new ProcessGrade();

            [HttpGet, Route("grades")]
            [ResponseType(typeof(List<GradeDto>))]
            public HttpResponseMessage GetGrades()
            {
                var gradeList = gradeP.GetGrades();
                return Request.CreateResponse(HttpStatusCode.OK, gradeList);
            }

            [HttpGet, Route("grade/{id}")]
            [ResponseType(typeof(GradeDto))]
            public HttpResponseMessage GetGrade(int id)
            {
                var grade = gradeP.GetGrade(id);
                return Request.CreateResponse(HttpStatusCode.OK, grade);

            }

            [HttpPost, Route("grade/")]
            [ResponseType(typeof(GradeDto))]
            public HttpResponseMessage CreateGrade(GradeDto grade)
            {
                var newGrade = gradeP.InsertNewGrade(grade);
                return Request.CreateResponse(HttpStatusCode.OK, newGrade);
            }

            [HttpPut, Route("grade/{id}")]
            [ResponseType(typeof(GradeDto))]
            public HttpResponseMessage UpdateGrade(GradeDto gradeDto)
            {
                gradeP.UpdateGrade(gradeDto);
                return Request.CreateResponse(HttpStatusCode.OK);

            }

            [HttpDelete, Route("grade/{id}")]
            public HttpResponseMessage DeleteGrade(int id)
            {
                var grade = gradeP.GetGrade(id);
                gradeP.DeleteGrade(grade);
                return Request.CreateResponse(HttpStatusCode.OK);

            }
    }
}
