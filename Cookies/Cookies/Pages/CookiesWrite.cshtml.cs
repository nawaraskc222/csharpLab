using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cookies.Pages
{
    public class CookiesWriteModel : PageModel
    {
        [BindProperty]
        public string CookieName { get; set; } 
        public async Task<IActionResult> OnPostAsyns()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTimeOffset.Now.AddMinutes(1);
            Response.Cookies.Append("myName", CookieName, option);
            return RedirectToPage("./DisplayCookie");
        }
        public void OnGet()
        {
        }
    }
}
