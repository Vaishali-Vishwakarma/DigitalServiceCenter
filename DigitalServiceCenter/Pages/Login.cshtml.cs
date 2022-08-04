using DigitalServiceCenter.Models;
using DigitalServiceCenter.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DigitalServiceCenter.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }

        private readonly CompaneyDbContext _db;
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(CompaneyDbContext db, SignInManager<IdentityUser> signInManager)
		{
			_db = db;
            this.signInManager = signInManager;
        }


        public void OnGet()
        {
        }
        /*[BindProperty]
		public Admin admin { get; set; }*/
		/*public IActionResult OnPost()
		{
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var isuser = _db.Admin.Where(x => x.Email == admin.Email &&
                            x.Password == admin.Password).FirstOrDefault();
                if (isuser != null)
                {
                    return Redirect("/Registration");
                }
                return BadRequest("Invalid user login");
            }
		}*/

        public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    if(returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("ServiceCenter");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "Username or Password incorrect!");
            }
            return Page();
        }
    }
}
