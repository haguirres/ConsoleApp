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
    [Route("api/address")]
    public class AddressController : ApiController
    {
        ProcessAddress processAddress;

        public AddressController()
        {
            processAddress = new ProcessAddress();
        }

        [HttpGet, Route("address")]
        [ResponseType(typeof(List<AddressDto>))]
        public HttpResponseMessage GetAddress()
        {
            var addressList = processAddress.GetAddress();
            return Request.CreateResponse(HttpStatusCode.OK, addressList);
        }

        [HttpGet, Route("address/{id}")]
        [ResponseType(typeof(AddressDto))]
        public HttpResponseMessage GetAddress(int id)
        {
            var address = processAddress.GetAddress(id);
            return Request.CreateResponse(HttpStatusCode.OK, address);

        }

        [HttpPost, Route("address")]
        [ResponseType(typeof(AddressDto))]
        public HttpResponseMessage CreateAddress(AddressDto addressDto)
        {

            int address = processAddress.InsertAddress(addressDto);

            return Request.CreateResponse(HttpStatusCode.OK);
        }


        [HttpDelete, Route("address/{id}")]
        [ResponseType(typeof(AddressDto))]
        public HttpResponseMessage DeleteAddress(int id)
        {
            processAddress.DeleteAddress(id);
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpPut, Route("address")]
        [ResponseType(typeof(AddressDto))]
        public HttpResponseMessage UpdateAddress(AddressDto addressDto)
        {
            processAddress.UpdateAddress(addressDto);
            return Request.CreateResponse(HttpStatusCode.OK,addressDto);

        }

    }
}
