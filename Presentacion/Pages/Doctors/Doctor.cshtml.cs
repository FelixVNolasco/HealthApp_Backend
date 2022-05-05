using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class DoctorModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public DoctorModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}