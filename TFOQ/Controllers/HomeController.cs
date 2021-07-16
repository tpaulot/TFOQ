using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFOQ.Models;
using TFOQ.Repository;

namespace TFOQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MantimentosRepository repository = new MantimentosRepository();
            List<Mantimentos> lista = repository.GetMantimentos();

            return View();
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