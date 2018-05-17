using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class Employee : DefaultInput
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}