using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class ClinicalSpecialtyModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ClinicalSpecialtyModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}