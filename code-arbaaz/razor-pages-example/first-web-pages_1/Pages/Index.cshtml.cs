using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first_web_pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Arbaaz Patwari";
        }

        public void OnPost()
        {
            ViewData["Message"] = "Hello" + FullName;
        }
    }
}