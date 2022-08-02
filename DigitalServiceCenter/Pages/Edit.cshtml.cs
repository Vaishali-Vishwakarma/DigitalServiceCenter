using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigitalServiceCenter.Pages
{
    public class EditModel : PageModel
    {
		private readonly CompaneyDbContext _db;
		public Companey companey = new Companey();

		public EditModel(CompaneyDbContext db)
		{
			this._db = db;
		}

        public void OnGet()
        {
            var Id = Convert.ToInt32(Request.Query["Id"]);
            this.companey = _db.Companeys.Find(Id);
        }
        public IActionResult OnPost(Companey companey)
		{
            var Companey = _db.Companeys.Find(companey.Id);

            if (companey != null)
			{
                Companey.CompaneyName = companey.CompaneyName;
                Companey.Email = companey.Email;
                Companey.Subject = companey.Subject;
                Companey.Discription = companey.Discription;
                Companey.AddressContactInfo = companey.AddressContactInfo;
                
                _db.SaveChanges();
                return Redirect("/Services");
            }
            return NotFound();
        }
    }
}
