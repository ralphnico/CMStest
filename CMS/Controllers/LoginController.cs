using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Models;
using System.Web.Security;
using System.Data.Entity;

namespace CMS.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                if (IsUser(model.username, model.password)) //Check data store where username password exists
                {
                    //Set false to true to make the cookie persistante between sessions
                    FormsAuthentication.SetAuthCookie(model.username, false);
                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError("", "Invalid username or password");
            }
            return View();
        }

        private bool IsUser(string username, string password)
        {
            bool valid = false;
            using (var db = new DataContext())
            {
                valid = db.Users.Any(lm => lm.username == username && lm.password == password);
            }
            return valid;
        }
    }
}
