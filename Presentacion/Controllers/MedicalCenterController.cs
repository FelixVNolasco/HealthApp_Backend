using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;

using Models.Entities;

namespace Presentacion.Controllers
{
    public class MedicalCenterController : Controller
    {
        // GET: MedicalCenterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicalCenterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicalCenterController/Create
        public ActionResult Create(CreateMedicalCenterDto createMedicalCenterDto)
        {
            return View();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64189/api/student");


                var postTask = client.PostAsync(client.BaseAddress, createMedicalCenterDto);
            }
        }

        // POST: MedicalCenterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalCenterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalCenterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalCenterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalCenterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
