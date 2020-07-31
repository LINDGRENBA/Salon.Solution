using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EauSalon.Models;
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
  }
}