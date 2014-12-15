using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(int? id, string name)
        {
            return "Welcome. Id:" + ((id == null)? id.ToString() : "") + "; name:" + name;
        }

        

    }
}
