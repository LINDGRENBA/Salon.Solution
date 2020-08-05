using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EauSalon.Models; 
using System.Linq;

namespace EauSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly EauSalonContext _db;
    
    public ClientsController(EauSalonContext db)
    {
      _db = db;
    }

        public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      // List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
      Client thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }
  }
}
