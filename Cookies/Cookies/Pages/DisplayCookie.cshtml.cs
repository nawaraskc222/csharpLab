using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cookies.Pages
{
    public class DisplayCookieModel : PageModel
    {
        public string firstname;
        public string lastname;
        public string email;
        public void OnGet()
        {
            firstname = Request.Cookies["firstname"];
            lastname = Request.Cookies["lastname"];
            email = Request.Cookies["email"];
        }
    }
}
