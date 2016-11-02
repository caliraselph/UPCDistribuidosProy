using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace upcDistribuidos.WebApi.Controllers
{
    public class SeguridadController : ApiController
    {
        // GET: api/Seguridad
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Seguridad/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Seguridad
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Seguridad/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Seguridad/5
        public void Delete(int id)
        {
        }
    }
}
