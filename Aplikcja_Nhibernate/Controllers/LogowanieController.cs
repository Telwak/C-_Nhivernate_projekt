using NHibernate;
using NHibernate.Linq;
using NHibernateMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aplikcja_Nhibernate.Controllers
{
    public class LogowanieController : Controller
    {
        // GET: Logowanie
        public ActionResult Index() { 
      
            return View();
        }
        [HttpPost]
        public ActionResult Logowanie(ValidationUsers obj, Login_Logout Walidacja)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
               

                    var persons = session.Query<Users>()
                .Where(x => x.Name == obj.Name && x.Password == obj.Password)
                .Count();
   
                if (persons == 0)
                {
                    ViewBag.message = "Nie znaleziono użytkownika!";
                    return View("Index");
                
                }
                // Login_Logout Poprawność = new Login_Logout();
                Walidacja.Czy_zalogowano = true;
                return Redirect("/Panel/Panel/");
            
            }

        }

    }
}