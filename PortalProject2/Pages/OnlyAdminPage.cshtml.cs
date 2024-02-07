using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortalProject2.Pages
{
    [Authorize(Roles ="Admin")]
    public class OnlyAdminPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
