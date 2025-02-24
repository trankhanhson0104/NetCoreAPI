using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class employeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult welcome()
        {
            return View();
        }
    }
}
