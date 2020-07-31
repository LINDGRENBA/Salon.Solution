using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EauSalon.Models; // get stuff from the models folder
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


  }
}
