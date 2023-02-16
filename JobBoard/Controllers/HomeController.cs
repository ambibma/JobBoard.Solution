using Microsoft.AspNetCore.Mvc;

namespace Jobs.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}