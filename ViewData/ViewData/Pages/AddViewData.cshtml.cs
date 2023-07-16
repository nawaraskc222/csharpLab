using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViewData.Pages
{
    public class AddViewDataModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            TempData["FirstName"] = FirstName;
            TempData["LastName"] = LastName;
            TempData["Email"] = Email;

            return RedirectToPage("./ViewDataDisplay");
        }
        public void OnGet()
        {
        }
    }
}
