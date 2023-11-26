using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;


namespace SistemaGestorPacientes.Controllers
{
    public class LoginController : Controller
    {


        private readonly IUserServices _userServices;

        public LoginController(IUserServices userServices)
        {
            _userServices = userServices;
        
        }

        public IActionResult Index()
        {
           
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel vm)
        {
            try
            {
                
                if (!ModelState.IsValid)
                {
                    return View("Index", vm);
                }
                UserViewModel user = await _userServices.LoginAsync(vm);

                

                return View("Index", vm);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        
    }
}