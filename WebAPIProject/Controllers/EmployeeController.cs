using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetEmployees(Employee objEmployee)
        {
            if (objEmployee.GetCheckSum())
                return Ok("CheckSum Working.....");
            return Ok($"Checksum failed for:{objEmployee.UserID}");
        }
    }
}
