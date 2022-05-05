using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class EditClinicalSpecialty : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public EditClinicalSpecialty(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}