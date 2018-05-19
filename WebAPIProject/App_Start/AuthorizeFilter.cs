using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebAPIProject.Models;

namespace WebAPIProject.App_Start
{
    public class AuthorizeFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var userInput = (DefaultInput)actionContext.ActionArguments.Values.AsQueryable().SingleOrDefault();
            if (userInput.UserID == "16341" && userInput.Password == "Powai")
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Accepted, "Authentication Failure");
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.ProxyAuthenticationRequired, "Authentication Failure");
        }
    }
}