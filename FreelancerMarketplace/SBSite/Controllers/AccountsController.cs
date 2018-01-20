using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreelancerMarketplace.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}