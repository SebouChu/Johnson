using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Johnson.Models;

namespace Johnson.Controllers
{
    public class ClientsController : Controller
    {
        public ActionResult Index()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.getClientsList();

            return View();
        }
    }
}
