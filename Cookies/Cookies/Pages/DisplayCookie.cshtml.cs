using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cookies.Pages
{
    public class DisplayCookieModel : PageModel
    {
        public string CookieName;
        public void OnGet()
        {
            CookieName = Request.Cookies["myName"];
        }
    }
}
