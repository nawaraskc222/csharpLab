using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddSubDiv.Pages
{
    public class DivModel : PageModel
    {

        [BindProperty]
        public float Number1 { get; set; }

        [BindProperty]
        public float Number2 { get; set; }

        public float Result;

        public void OnPost()
        {
            Result = Number1 / Number2;
        }
        public void OnGet()
        {
        }
    }
}
