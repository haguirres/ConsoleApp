using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace School.NetFramework.Api
{
    public class ExceptionsWebApi
    {
        public static HttpResponseException SchoolNotFound
        {
            get { return StructJson("No se encontraron coincidencias con alguna escuela", HttpStatusCode.ExpectationFailed); }
        }

        private static HttpResponseException StructJson(string message, HttpStatusCode statusCode)
        {
            return new HttpResponseException(new HttpResponseMessage(statusCode)
            {
                Content = new StringContent("{\"error\": \"" + message + "\"}", Encoding.UTF8, "application/json")
            });
        }
    }
}