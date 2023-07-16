using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddFiveStudent.Pages
{
    public class CreateStudentModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
        }
    }
}
