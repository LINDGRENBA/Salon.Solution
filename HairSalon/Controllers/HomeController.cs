using Microsoft.AspNetCore.Mvc;

namespace EauSalon.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}