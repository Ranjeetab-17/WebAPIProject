using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIProject.App_Start
{
    public class MyWebApiFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //StreamWriter file = new StreamWriter(@"E:/APIError.txt");
            //file.WriteLine($"Actionname : {actionContext.ActionDescriptor.ActionName}");
            base.OnAuthorization(actionContext);
        }
        //public bool AllowMultiple { get; }

        //public Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken,
        //    Func<Task<HttpResponseMessage>> continuation)
        //{
        //    StreamWriter file=new StreamWriter(@"D:/myApiLog.txt");
        //    file.WriteLine($"ActionName : {actionContext.ActionDescriptor.ActionName}");
        //    throw new NotImplementedException();
        //}
    }
}