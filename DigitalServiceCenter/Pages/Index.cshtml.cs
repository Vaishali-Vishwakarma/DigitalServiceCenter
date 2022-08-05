using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigitalServiceCenter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        CompaneyDbContext _db;
        public IndexModel(ILogger<IndexModel> logger, CompaneyDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public List<Companey> Companeys { get; set; }
        public void OnGet()
        {
            this.Companeys = _db.Companeys.Where(x => x.Status == true).ToList();
        }
        /*public void OnGet([FromRoute] string ImageName)
        {
            var companey = _db.Companeys.Find(ImageName);

            if (companey != null)
            {
                */
        /*companey.CompaneyName = updateAdminRequest.Name;
                companey.Email = updateAdminRequest.Role;
                companey.Subject = updateAdminRequest.Email;
                companey.Discription = updateAdminRequest.Password;
                companey.AddressContactInfo = DateTime.Now;
                companey.ImagePath = DateTime.Now;

                await db.SaveChangesAsync();
                return Ok(companey);*/
        /*
                this.Companeys = _db.Companeys.Where(x => x.ImageName == ImageName).ToList();
            }
            //return NotFound();
        }*/
    }
}