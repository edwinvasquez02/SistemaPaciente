using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.LabResultViewModels;
using Microsoft.AspNetCore.Mvc;


namespace SistemaPaciente.Controllers
{
    public class LabResultsController : Controller
    {
        private readonly ILabResultServices _labResultServices;

        public LabResultsController(ILabResultServices labResultServices)
        {
            _labResultServices = labResultServices;
            
        }

        public async Task<IActionResult> Index(FilterLabResultViewModel filter)
        {
            try
            {
                
                return View(await _labResultServices.GetByFiltersAsync(filter));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public async Task<IActionResult> Report(int id)
        {
            try
            {
                

                var labResultCreated = await _labResultServices.GetById(id);
                return View(labResultCreated);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Report(SaveLabResultViewModel vm)
        {
            try
            {
                
                //Reportando resultados.
                var LabResultCreated = await _labResultServices.GetById(vm.Id);
                LabResultCreated.IsCompleted= true;
                LabResultCreated.Comments = vm.Comments;


                await _labResultServices.Update(LabResultCreated, LabResultCreated.Id);
                return RedirectToRoute(new { controller = "LabResults", action = "Index" });
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
