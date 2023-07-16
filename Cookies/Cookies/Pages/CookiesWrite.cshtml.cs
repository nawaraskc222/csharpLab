using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cookies.Pages
{
    public class CookiesWriteModel : PageModel
    {
        

        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string firstname { get; set; }
        [BindProperty]
        public string lastname { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTimeOffset.Now.AddMinutes(5);
            Response.Cookies.Append("firstname", firstname, option);
            Response.Cookies.Append("lastname", lastname, option);
           
            Response.Cookies.Append("email", email, option);

            return RedirectToPage("./DisplayCookie");
        }
        public void OnGet()
        {
        }
    }
}
