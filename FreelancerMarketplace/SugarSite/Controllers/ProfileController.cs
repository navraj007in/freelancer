using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SugarSite.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SugarBaby()
        {
            return View();
        }

        public ActionResult SugarDaddy()
        {
            return View();
        }

    }
}