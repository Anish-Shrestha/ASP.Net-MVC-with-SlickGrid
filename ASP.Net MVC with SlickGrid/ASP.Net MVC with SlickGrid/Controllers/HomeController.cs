using ASP.Net_MVC_with_SlickGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ASP.Net_MVC_with_SlickGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getEmployeeList()
        {
            List<Employee> theSquad = new List<Employee>{
                new Employee{Id=4, Name="Mertesacker",Salary=10000,Address="Fairfield, Iowa"},
                new Employee{Id=5, Name="Vermaelen",Salary=3000,Address="Fairfield, Iowa"},
                new Employee{Id=7, Name="Rosicky",Salary=7000,Address="Fairfield, Iowa"},
                new Employee{Id=8, Name="Arteta",Salary=10000,Address="Fairfield, Iowa"},
                new Employee{Id=10, Name="Vane Persie",Salary=56000,Address="Fairfield, Iowa"},
                new Employee{Id=11, Name="Santos",Salary=56000,Address="Fairfield, Iowa"},
                new Employee{Id=13, Name="Szczesney",Salary=100000,Address="Fairfield, Iowa"},
                new Employee{Id=14, Name="Walcott",Salary=12000,Address="Fairfield, Iowa"},
                new Employee{Id=17, Name="Song",Salary=100000,Address="Fairfield, Iowa"},
                new Employee{Id=19, Name="Wilshere",Salary=12000,Address="Fairfield, Iowa"},
                new Employee{Id=28, Name="Gibbs",Salary=100000,Address="Fairfield, Iowa"}
                };

            return Json(theSquad, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}