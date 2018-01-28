using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SugarSite.Controllers
{
    public class ProfileController : Controller
    {
        Entities db = new Entities();
        // GET: Profile
        public ActionResult Index()
        {
            string userid = HttpContext.User.Identity.GetUserId();
            var profile = (from x in db.Profiles
                           where x.userId == userid
                           select x).FirstOrDefault();

            return View(profile);
        }

        public ActionResult SugarBaby()
        {
            string userid = HttpContext.User.Identity.GetUserId();
            var profile = (from x in db.Profiles
                           where x.userId == userid
                           select x).FirstOrDefault();

            return View(profile);
        }

        public ActionResult SugarDaddy()
        {
            string userid = HttpContext.User.Identity.GetUserId();
            var profile = (from x in db.Profiles
                           where x.userId == userid
            select x).FirstOrDefault();

            return View(profile);
        }
        [HttpPost]
        public ActionResult SugarDaddy(Profile profile)
        {
            string userid = HttpContext.User.Identity.GetUserId();
            
            
           
            try
            {
                db.Entry(profile).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return View(profile);
        }
    }
}