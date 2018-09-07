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
    [Route("api/catalogs")]
    public class CatalogsController : ApiController
    {
        ProcessCatalogs processCatalogs;
        public CatalogsController()
        {
            processCatalogs = new ProcessCatalogs();
        }

        [HttpGet, Route("roles")]
        [ResponseType(typeof(List<RolDto>))]
        public HttpResponseMessage GetRoles()
        {
            var rolList = processCatalogs.GetRoles();
            return Request.CreateResponse(HttpStatusCode.OK, rolList);
        }
    }
}
