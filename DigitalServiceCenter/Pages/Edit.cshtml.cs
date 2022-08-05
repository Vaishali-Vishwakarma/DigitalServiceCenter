using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigitalServiceCenter.Pages
{
    public class EditModel : PageModel
    {
		private readonly CompaneyDbContext _db;
        
        public EditModel(CompaneyDbContext db)
		{
			this._db = db;
		}

        

        public Companey companey { get; set; }/* = new Companey();*/
        public void OnGet()
        {
            //var Id = Convert.ToInt32(Request.Query["Id"]);
            companey = _db.Companeys.Find(Convert.ToInt32(Request.Query["Id"]));
        }

        public Companey Company { get; set; }
        public IActionResult OnPost(Companey com)
		{
            Company = _db.Companeys.Find(com.Id);

            if (com != null)
            {
                Company.CompaneyName = com.CompaneyName;
                Company.Email = com.Email;
                Company.Subject = com.Subject;
                Company.Discription = com.Discription;
                Company.AddressContactInfo = com.AddressContactInfo;
                /*Company.Status = com.Status.ToString().ToLower() == "on" ? true : false;*/
                Company.Status = com.Status;

                _db.SaveChanges();
                return Redirect("/Services");
            }
            return NotFound();
        }
    }
}
