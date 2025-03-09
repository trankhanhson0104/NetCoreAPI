using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "luyenTapThucHanh";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "This is the Person Details page.";
            return View();
        }
    }
}