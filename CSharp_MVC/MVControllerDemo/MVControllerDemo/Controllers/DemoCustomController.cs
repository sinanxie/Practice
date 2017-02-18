using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVControllerDemo.Controllers
{
    public class DemoCustomController : IController
    {
        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            var controller = (string)requestContext.RouteData.Values["controller"];
            var action = (string)requestContext.RouteData.Values["action"];
            requestContext.HttpContext.Response.Write(
            string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }
}