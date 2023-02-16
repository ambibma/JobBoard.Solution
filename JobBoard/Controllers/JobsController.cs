using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Jobs.Models;

namespace Jobs.Controllers
{
  public class JobsController : Controller
  {
    
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Opening> allOpenings = Opening.GetAll();
      return View(allOpenings);
    }
    
    [HttpGet("/jobs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Index(string title, string description, string salary, string name, string email, string phoneNumber)
    {
      Contact newContact = new Contact (name, email, phoneNumber);
      Opening newOpening = new Opening (title, description, salary, newContact);
      return View(Opening.GetAll());
    }
  }
}