using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebAPIProject.Models;

namespace WebAPIProject.App_Start
{
    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var header = actionContext.Request.Headers.SingleOrDefault(x => x.Key == "CheckSum").Value.SingleOrDefault();
            var datetTimeStamp = actionContext.Request.Headers.SingleOrDefault(x => x.Key == "DateTimeStamp").Value.SingleOrDefault();             
            var actionName = actionContext.ActionDescriptor.ActionName;
            var controllerName = actionContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var userInput = (DefaultInput)actionContext.ActionArguments.Values.AsQueryable().SingleOrDefault();
            if (userInput.UserID == "IFAAPPTEST" && userInput.Password == "Powai")
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Accepted, "CheckSum Success");
            actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.PreconditionFailed, "CheckSum Failed");
        }       
    }
}