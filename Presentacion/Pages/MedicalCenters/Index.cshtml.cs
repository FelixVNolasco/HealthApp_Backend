using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentacion.Pages
{
    public class ListMedicCenterModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ListMedicCenterModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}