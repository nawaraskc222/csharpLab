using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sessions.Pages
{
    public class DisplaySessionModel : PageModel
    {

        public string FName;
        public string LName;
        public string Email;

        public void OnGet()
        {
            FName = HttpContext.Session.GetString("FName");
            LName = HttpContext.Session.GetString("LName");
            Email = HttpContext.Session.GetString("Email");
        }
    }
}
