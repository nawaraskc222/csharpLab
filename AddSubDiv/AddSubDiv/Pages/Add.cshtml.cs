using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddSubDiv.Pages
{
    public class AddModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }

        public int Result;

        public void OnPost()
        {
            Result = Number1 + Number2;
        }
        public void OnGet()
        {
        }
    }
}
