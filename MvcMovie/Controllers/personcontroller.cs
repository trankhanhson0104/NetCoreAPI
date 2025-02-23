using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class personController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chao " + ps.PersonId + " - " + ps.Fullname + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
    }
}
