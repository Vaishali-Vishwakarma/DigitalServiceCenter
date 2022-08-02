using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigitalServiceCenter.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly CompaneyDbContext db;
        public List<Companey> Companeys { get; set; }

        public ServicesModel(CompaneyDbContext db)
        {
            this.db = db;
        }
        
        public void OnGet(string? CompaneyName)
        {
            if (CompaneyName != null)
            {
                Companeys = db.Companeys.Where(x => x.CompaneyName == CompaneyName).ToList();
                CompaneyName = null;
            }
            else
            {
                Companeys = db.Companeys.ToList();
            }
        }
    }
}
