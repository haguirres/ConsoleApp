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
        [Route("api/Person")]
        public class PersonController : ApiController
        {
            ProcessPerson personP;
            public PersonController() => personP = new ProcessPerson();

            [HttpGet, Route("persons")]
            [ResponseType(typeof(List<PersonDto>))]
            public HttpResponseMessage GetPersons()
            {
                var personList = personP.GetPersons();
                return Request.CreateResponse(HttpStatusCode.OK, personList);
            }

            [HttpGet, Route("person/{id}")]
            [ResponseType(typeof(PersonDto))]
            public HttpResponseMessage GetPerson(int id)
            {
                var person = personP.GetPerson(id);
                return Request.CreateResponse(HttpStatusCode.OK, person);

            }

            [HttpPost, Route("person")]
            [ResponseType(typeof(PersonDto))]
            public HttpResponseMessage CreatePerson(PersonDto person)
            {
                var newPerson = personP.InsertNewPerson(person);
                return Request.CreateResponse(HttpStatusCode.OK, newPerson);
            }

            [HttpPut, Route("person")]
            [ResponseType(typeof(PersonDto))]
            public HttpResponseMessage UpdatePerson(PersonDto personDto)
            {
                personP.UpdatePerson(personDto);
                return Request.CreateResponse(HttpStatusCode.OK);

            }

            [HttpDelete, Route("person/{id}")]
            public HttpResponseMessage DeletePerson(int id)
            {
                var person = personP.GetPerson(id);
                personP.DeletePerson(person);
                return Request.CreateResponse(HttpStatusCode.OK);

            }
        }
}
