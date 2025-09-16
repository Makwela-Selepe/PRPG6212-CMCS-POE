using Microsoft.AspNetCore.Mvc;

namespace CMCS_PROG6212_POE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Lecturer() => View();
        public IActionResult Coordinator() => View();
        public IActionResult Manager() => View();
        public IActionResult Login() => View();
    }
}
