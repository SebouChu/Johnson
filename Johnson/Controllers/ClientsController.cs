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

        public ActionResult Search(string query)
        {
            Clients clients = new Clients();
            List<Client> results = HttpContext.Request.HttpMethod == "POST" ? clients.searchClients(query)
                                                                            : new List<Client>();
            ViewData["Results"] = results;
            ViewData["ResultsCount"] = results.Count;
            ViewData["Query"] = query;

            return View();
        }
    }
}
