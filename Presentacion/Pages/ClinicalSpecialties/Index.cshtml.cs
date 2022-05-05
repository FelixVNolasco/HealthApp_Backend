using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class ListClinicalSpecialtyModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ListClinicalSpecialtyModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}