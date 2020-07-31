using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EauSalon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace EauSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly EauSalonContext _db; //create datatype EauSalonContex, name it _db
    public StylistsController(EauSalonContext db) //set value of _db created above to the database
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.OrderBy(stylist => stylist.Name).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.WorkDay = new SelectList(_db.Stylists, "ScheduledWorkDays", "Scheduled Work Day");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View (thisStylist);
    }
  }
}