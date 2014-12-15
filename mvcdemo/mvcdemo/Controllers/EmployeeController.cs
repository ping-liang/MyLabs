using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo.Models;

namespace mvcdemo.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            DatabaseContext dbcontext = new DatabaseContext();

            return View(dbcontext.Employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(long id)
        {
            DatabaseContext dbcontext = new DatabaseContext();
           var employee = dbcontext.Employees.SingleOrDefault(emp => emp.Id == id);
          
           return View(employee);
        }

        public ActionResult Edit(long id)
        {
            DatabaseContext dbcontext = new DatabaseContext();
            var employee = dbcontext.Employees.SingleOrDefault(emp => emp.Id == id);

            return View(employee);
        }

       

    }
}
