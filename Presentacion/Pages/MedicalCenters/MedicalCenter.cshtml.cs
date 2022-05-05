using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class MedicalCenter : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MedicalCenter(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}