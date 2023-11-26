using Microsoft.AspNetCore.Mvc;


namespace SistemaPaciente.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
