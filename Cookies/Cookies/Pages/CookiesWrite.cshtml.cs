using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cookies.Pages
{
    public class CookiesWriteModel : PageModel
    {
        

        [BindProperty]
        public string CookiesName { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTimeOffset.Now.AddMinutes(5);
            Response.Cookies.Append("myName", CookiesName, option);

            return RedirectToPage("./DisplayCookie");
        }
        public void OnGet()
        {
        }
    }
}
