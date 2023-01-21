using isii_lab01_jrvaley.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace isii_lab01_jrvaley.Controllers
{
    public class HomeController : Controller
    {
        private readonly Singleton _singleton;
        private readonly Transient _transient;
        private readonly Scope _scope;


        public HomeController(Singleton singleton, Transient transient, Scope scope)
        {
           _singleton = singleton;
           _transient = transient;
           _scope = scope;

            
        }

        public IActionResult Index()
        {
            ViewBag.transient = _transient;
            ViewBag.singleton = _singleton;
            ViewBag.scope = _scope;



            return View();
        }

    }
}