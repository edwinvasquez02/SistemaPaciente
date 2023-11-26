﻿using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.PatientViewModels;
using Microsoft.AspNetCore.Mvc;


namespace SistemaPaciente.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
       

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
         
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _patientService.GetAll());
        }

        public IActionResult Create()
        {
           
            return View(new SavePatientViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePatientViewModel vm)
        {
            try
            {
                
                if (!ModelState.IsValid)
                {
                    return View("Create", vm);
                }
                SavePatientViewModel patientCreated = await _patientService.Add(vm);

                if (patientCreated != null && patientCreated.Id != 0)
                {
                    patientCreated.ImageUrl = _patientService.UplpadFile(vm.File, patientCreated.Id);
                    await _patientService.Update(patientCreated, patientCreated.Id);
                }
                return RedirectToRoute(new { controller = "Patient", action = "Index" });

            }
            catch (Exception ex)
            {
                return View("Index", ex);
            }

        }

        public async Task<IActionResult> Update(int id)
        {
           
            var patient = await _patientService.GetById(id);
            return View("Create", patient);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SavePatientViewModel vm)
        {
            try
            {
                
                if (!ModelState.IsValid)
                {
                    //Validando que si estoy editando el mismo paciente con su cedula, si es el mismo se edita
                    var userExisted = await _patientService.GetById(vm.Id);
                    if ((vm.Id == userExisted.Id) && (vm.Identification == userExisted.Identification))
                    {
                        await _patientService.Update(vm, vm.Id);
                        return RedirectToRoute(new { controller = "Patient", action = "Index" });
                    }
                    //Si no era el mismo, y era otro diferente que queria cambiar su cedula, le dara el mensaje.
                    return View("Create", vm);
                }
                //Cambiar la foto del paciente.
                SavePatientViewModel patientCreated = await _patientService.GetById(vm.Id);
                if (patientCreated != null && patientCreated.Id != 0)
                {
                    vm.ImageUrl = _patientService.UplpadFile(vm.File, patientCreated.Id, true, patientCreated.ImageUrl);
                    await _patientService.Update(vm, vm.Id);
                }
                return RedirectToRoute(new { controller = "Patient", action = "Index" });
            }
            catch (Exception ex)
            {
                return View("Index", ex);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
               
                var patient = await _patientService.GetById(id);
                return View("Delete", patient);
            }
            catch (Exception ex)
            {
                return View("Index", ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteP(int id)
        {
            try
            {
                await _patientService.Delete(id);
                return RedirectToRoute(new { controller = "Patient", action = "Index" });

            }
            catch (Exception ex)
            {
                return View("Index", ex.Message);
            }
        }
    }
}
