using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Contracts;

namespace QueryString.Pages
{
    public class QueryStringReadModel : PageModel
    {
        public string Name;
        public void OnGet(string myname)
        {
            Name = myname;
        }
    }
}
