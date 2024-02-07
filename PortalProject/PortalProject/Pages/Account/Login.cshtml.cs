using Service.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace PortalProject.Pages.Account
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public LoginUser UserCredential { get; set; }

        public LoginModel()
        {
           
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (UserCredential.Username == "admin" &&
                UserCredential.Password == "asd")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"tester"),
                    new Claim(ClaimTypes.Role,"Admin"),
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
