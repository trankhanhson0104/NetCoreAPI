using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class DiemmhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Diemmh dmh)
        {
            double diemmh = (dmh.Diema * 0.6) + (dmh.Diemb * 0.3) + (dmh.Diemc * 0.1);
            ViewBag.Dmh = diemmh;
            return View();
        }
    }
}