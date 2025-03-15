using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View() ;
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "bạn có người yêu chưa " + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }

    }
}