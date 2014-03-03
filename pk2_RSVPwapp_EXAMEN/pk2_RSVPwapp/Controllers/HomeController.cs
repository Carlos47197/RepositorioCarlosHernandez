using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pk2_RSVPwapp.Models;

namespace pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos Dias!!!" : "Buenas Tardes!!!";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //Verificando errores de validacion
            if (ModelState.IsValid)
            {
                //TODO: enviar respuesta al correo del organizador
                return View("Agradecimientos", guestResponse);
            }
            else
            {
                // Hay un problema de validacion
                return View();
            }

        }

    }
}
