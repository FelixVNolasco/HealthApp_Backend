using HealthAppFrontend.DataRepository.IDataRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthAppFrontend.Controllers
{
    public class DoctorFrontController : Controller
    {

        private readonly IDoctorFrontRepository _doctorFrontRepository;

        public DoctorFrontController(IDoctorFrontRepository doctorFrontRepository)
        {
            _doctorFrontRepository = doctorFrontRepository;
        }
        // GET: DoctorFrontController
        public async Task<ActionResult> Index()
        {
            string UrlWebApi = "http://localhost:20495/doctores";
            return View(await _doctorFrontRepository.GetAllAsync(UrlWebApi));
        }

        // GET: DoctorFrontController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string UrlWebApi = $"http://localhost:20495/doctores/{id}";
            return View(await _doctorFrontRepository.GetByIdAsync(UrlWebApi));
        }

        // GET: DoctorFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorFrontController/Create
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

        // GET: DoctorFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorFrontController/Edit/5
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

        // GET: DoctorFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorFrontController/Delete/5
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
