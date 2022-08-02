using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DigitalServiceCenter.Pages
{
    public class LoginModel : PageModel
    {
		private readonly CompaneyDbContext _db;

		public LoginModel(CompaneyDbContext db)
		{
			_db = db;
		}
        public void OnGet()
        {
            
        }
        [BindProperty]
		public Admin admin { get; set; }
		public IActionResult OnPost()
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
		}
    }
}
