using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HoadonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Hoadon hd)
        {
            double hoadon = hd.soluong * hd.dongia;
            ViewBag.hoadon = hoadon;
            return View();
        }
    }
}