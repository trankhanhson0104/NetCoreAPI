using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "NEVER HAVE HER";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "NEVER HAVE HER";
            return View();
        }
    }
}