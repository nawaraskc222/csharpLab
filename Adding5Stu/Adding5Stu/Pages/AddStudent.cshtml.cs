using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Adding5Stu.Pages
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public int count=1;
        public void OnPost()
        {
            
        }
        public void OnGet()
        {

        }
    }
}
