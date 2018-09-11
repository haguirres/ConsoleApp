using School.Entities.DTOs;
using School.NetFramework.Bussiness;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace School.NetFramework.Api.Controllers
{
    [RoutePrefix("api/catalogs")]
    [EnableCors("*", "*", "*")]
    public class CatalogsController : ApiController
    {
        private ProcessCatalogs processCatalogs;

        public CatalogsController()
        {
            processCatalogs = new ProcessCatalogs();
        }

        [HttpGet, Route("rol/{rolId}")]
        //[HttpGet, Route("rol")]
        [ResponseType(typeof(RolDto))]
        public HttpResponseMessage GetRoles([FromUri]int rolId)
        {
            var rol = processCatalogs.GetRol(rolId);
            return Request.CreateResponse(HttpStatusCode.OK, rol);
        }

        [HttpGet, Route("roles")]
        [ResponseType(typeof(List<RolDto>))]
        public HttpResponseMessage GetRoles()
        {
            var rolList = processCatalogs.GetRoles();
            return Request.CreateResponse(HttpStatusCode.OK, rolList);
        }

        [HttpPost, Route("rol")]
        [ResponseType(typeof(int))]
        public HttpResponseMessage PostRol([FromBody]RolDto rolDto)
        {
            int rolId = processCatalogs.InsertNewRole(rolDto);
            return Request.CreateResponse(HttpStatusCode.Created, rolId);
        }

        [HttpPut, Route("rol/{rolId}")]
        public HttpResponseMessage PutRol([FromUri] int rolId, [FromBody] RolDto rolDto)
        {
            processCatalogs.UpdateRol(rolId, rolDto);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete, Route("rol/{rolId}")]
        public HttpResponseMessage DeleteRol([FromUri]int rolId)
        {
            processCatalogs.DeleteRol(rolId);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}