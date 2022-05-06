using HealthAppFrontend.DataRepository.IDataRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthAppFrontend.Controllers
{
    public class ClinicalSpecialtyFrontController : Controller
    {

        private readonly IClinicalSpecialtyRepository _clinicalSpecialtyRepository;

        public ClinicalSpecialtyFrontController(IClinicalSpecialtyRepository clinicalSpecialtyRepository)
        {
            _clinicalSpecialtyRepository = clinicalSpecialtyRepository;
        }
        // GET: ClinicalSpecialtyFrontController
        public async Task<ActionResult> Index()
        {
            string UrlWebApi = "http://localhost:20495/specialties";
            return View(await _clinicalSpecialtyRepository.GetAllAsync(UrlWebApi));
        }

        // GET: ClinicalSpecialtyFrontController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string UrlWebApi = $"http://localhost:20495/specialties/{id}";
            return View(await _clinicalSpecialtyRepository.GetByIdAsync(UrlWebApi));
        }

        // GET: ClinicalSpecialtyFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Create
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

        // GET: ClinicalSpecialtyFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Edit/5
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

        // GET: ClinicalSpecialtyFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Delete/5
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
