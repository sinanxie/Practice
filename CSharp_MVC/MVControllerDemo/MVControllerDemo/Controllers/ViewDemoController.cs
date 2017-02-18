using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVControllerDemo.Controllers
{
    public class ViewDemoController : Controller
    {
        //
        // GET: /ViewDemo/

        public class Blog
        {
            public string Name;
            public string URL;
        }

        private readonly List topBlogs = new List
        {
            new Blog { Name = "Joe Delage", URL = "http://tutorialspoint/joe/"},
            new Blog {Name = "Mark Dsouza", URL = "http://tutorialspoint/mark"},
            new Blog {Name = "Michael Shawn", URL = "http://tutorialspoint/michael"}
        };

        public ActionResult StonglyTypedIndex()
        {
            return View(topBlogs);
        }

        public ActionResult IndexNotStonglyTyped()
        {
            return View(topBlogs);
        }  

    }
}
