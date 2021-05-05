using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace bcc.Controllers
{
    public class HelloWordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Olá " + name;//ViewData é um dicionário
            ViewData["NumTimes"] = numTimes;
            return  View();
        }
    }
}