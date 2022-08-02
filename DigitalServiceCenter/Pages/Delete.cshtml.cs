using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigitalServiceCenter.Pages
{
    public class DeletModel : PageModel
    {
        private readonly CompaneyDbContext _db;
        public Companey companey = new Companey();
        public DeletModel(CompaneyDbContext db)
        {
            this._db = db;
        }

        public void OnGet(int Id)
        {
            this.companey = _db.Companeys.Find(Id);
        }

        [BindProperty]
        public Companey Companey { get; set; }
        public IActionResult OnPost()
        {
            var companey = _db.Companeys.Find(Companey.Id);
            if(companey != null)
            {
                _db.Companeys.Remove(companey);
                _db.SaveChanges();
                return Redirect("/Services");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
