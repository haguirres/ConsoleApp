using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using School.Entities.DTOs;
using School.NetFramework.Bussiness;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [Route("api/inscriptions")]
    public class InscriptionController : ApiController
    {
        ProcessInscription ProcessInscription;
        public InscriptionController()
        {
            ProcessInscription = new ProcessInscription();
        }

        [HttpGet, Route("inscriptions")]
        [ResponseType(typeof(List<InscriptionDto>))]
        public HttpResponseMessage GetInscriptions()
        {
            var inscriptionList = ProcessInscription.GetInscriptions();
            return Request.CreateResponse(HttpStatusCode.OK, inscriptionList);
        }

        [HttpGet, Route("inscription")]
        [ResponseType(typeof(InscriptionDto))]
        public HttpResponseMessage GetInscriptions(int StudentId, string SchoolId)
        {
            var inscription = ProcessInscription.GetInscription(StudentId, SchoolId);
            return Request.CreateResponse(HttpStatusCode.OK, inscription);
        }

        [HttpPost, Route("inscription")]
        [ResponseType(typeof(InscriptionDto))]
        public HttpResponseMessage InsertInscription(InscriptionDto inscription)
        {
            var InsertInsc = ProcessInscription.InsertInscription(inscription);
            return Request.CreateResponse(HttpStatusCode.OK, InsertInsc);
        }

        [HttpPut, Route("inscription")]
        [ResponseType(typeof(InscriptionDto))]
        public HttpResponseMessage UpdateInscription(InscriptionDto inscription)
        {
            ProcessInscription.UpdateInscription(inscription);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete, Route("inscription")]
        [ResponseType(typeof(InscriptionDto))]
        public HttpResponseMessage DeleteInscription(InscriptionDto inscription)
        {
            ProcessInscription.UpdateInscription(inscription);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
