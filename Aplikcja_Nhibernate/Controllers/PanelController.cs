using NHibernateMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikcja_Nhibernate.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        public ActionResult Panel(Login_Logout Walidacja)
        {
          if (Walidacja.Czy_zalogowano == false)
          {
                return Redirect("/Logowanie/Index");
           }
           return View();
        }
    }
}