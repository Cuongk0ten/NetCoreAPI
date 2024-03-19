using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();

    }
[HttpPost]
public IActionResult Index(Person ps )
{
    string str0utput ="Xin chao" + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
    ViewBag.infoPerson = str0utput;
    return View();

}
}
}
