﻿using SistemaPaciente.Core.Application.Interfaces.Services;
using SistemaPaciente.Core.Application.ViewModels.DoctorViewModels;
using Microsoft.AspNetCore.Mvc;


namespace SistemaPaciente.Controllers
{

    public class DoctorController : Controller
    {
        private readonly IDoctorServices _doctorServices;
       

        public DoctorController(IDoctorServices doctorServices)
        {
            _doctorServices = doctorServices;
       
        }

        public async Task<IActionResult> Index()
        {
           

            return View(await _doctorServices.GetAll());
        }

        public IActionResult Create()
        {
            
            return View(new SaveDoctorViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(SaveDoctorViewModel vm)
        {
            try
            {
                
                if (!ModelState.IsValid)
                {
                    return View("Create", vm);
                }

                SaveDoctorViewModel doctorCreated = await _doctorServices.Add(vm);
                
                return RedirectToRoute(new { controller = "Doctor", action = "Index" });
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public async Task<IActionResult> Update(int id)
        {
            try
            {
                
                var doctor = await _doctorServices.GetById(id);
                return View("Create", doctor);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> Update(SaveDoctorViewModel vm)
        {
            try
            {
                

                if (!ModelState.IsValid)
                {
                    return View("Create", vm);

                }


                SaveDoctorViewModel doctorCreated = await _doctorServices.GetById(vm.Id);
                if (doctorCreated != null && doctorCreated.Id != 0)
                {
                    vm.ImageUrl = _doctorServices.UplpadFile(vm.File, doctorCreated.Id, true, doctorCreated.ImageUrl);
                    await _doctorServices.Update(vm, doctorCreated.Id);
                }
                return RedirectToRoute(new { controller = "Doctor", action = "Index" });
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                
                var doctor = await _doctorServices.GetById(id);
                return View("Delete", doctor);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteP(int id)
        {
            try
            {
                
                await _doctorServices.Delete(id);
                return RedirectToRoute(new { controller = "Doctor", action = "Index" });
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
