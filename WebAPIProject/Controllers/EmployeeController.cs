using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIProject.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]        
        public IHttpActionResult GetEmployees()
        {
            return Ok();
        }
    }
}
