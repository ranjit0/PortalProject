using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortalProject.Pages
{
    [Authorize(Roles ="Admin")]
    public class OnlyAdminPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
