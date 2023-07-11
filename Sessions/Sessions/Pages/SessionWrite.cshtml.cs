using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sessions.Pages
{
    public class SessionWriteModel : PageModel
    {

        [BindProperty]
        public string FName { get; set; }
        [BindProperty]
        public string LName { get; set; }

        [BindProperty]
        public string Email { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            HttpContext.Session.SetString("FName", FName);
            HttpContext.Session.SetString("LName", LName);
            HttpContext.Session.SetString("Email", Email);
            return RedirectToPage("./DisplaySession");
        }


        public void OnGet()
        {
        }
    }
}
