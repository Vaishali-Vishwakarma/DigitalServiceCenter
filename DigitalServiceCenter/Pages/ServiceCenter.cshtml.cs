using DigitalServiceCenter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalServiceCenter.Pages
{
    [Authorize]
    public class ServiceCenterModel : PageModel
    {
        CompaneyDbContext _db;
        public readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceCenterModel(CompaneyDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public Companey Companey { get; set; }
        /*public IActionResult OnPost()
        {
            _db.Companeys.Add(Companey);
            _db.SaveChanges();
            return Redirect("/index");
        }*/

        public async Task<IActionResult> OnPost(CompaneyImage companeyImage)
        {
            if (companeyImage.File != null)
            {
                var fileName = Path.GetFileName(companeyImage.File.FileName);
                string ext = Path.GetExtension(companeyImage.File.FileName);
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);
                using (var fileStram = new FileStream(filePath, FileMode.Create))
                {
                    await companeyImage.File.CopyToAsync(fileStram);
                }
                var companey = new Companey()
                {
                    Id = Companey.Id,
                    CompaneyName = Companey.CompaneyName,
                    Email = Companey.Email,
                    Subject = Companey.Subject,
                    Discription = Companey.Discription,
                    AddressContactInfo = Companey.AddressContactInfo,
                    ImagePath = filePath,
                    ImageName = fileName,
                };
                _db.Companeys.Add(companey);
                _db.SaveChanges();
                return Redirect("/Index");
            }
            else
            {
                return BadRequest("No File Uploaded");
            }
            //return Ok("File Uploaded...");
        }
        /*public async Task<IActionResult> UploadFiles([FromForm] AddUserRequest addUserRequest)
        {
            /*if (addUserRequest.File != null)
            {
                //upload files to wwwroot 
                var fileName = Path.GetFileName(addUserRequest.File.FileName);
                // pdf file check
                string ext = Path.GetExtension(addUserRequest.File.FileName);
                if (ext.ToLower() != ".pdf")
                {
                    return View();
                }
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Documents", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await addUserRequest.File.CopyToAsync(fileStream);
                }

                //save file to database
                var user = new UserSignUp()
                {
                    Id = Guid.NewGuid(),
                    Name = addUserRequest.Name,
                    Role = "user",
                    Email = addUserRequest.Email,
                    Password = addUserRequest.Password,
                    LastLogin = DateTime.Now.Date,
                    LastUpdated = DateTime.Now.Date,
                    FilePath = filePath,
                };

                await dbContext.User.AddAsync(user);

                var document = new DocumentUpload()
                {
                    Id = user.Id,
                    //File = addUserRequest.File,
                    Status = "",
                    LastUpdated = DateTime.Now.Date,
                };

                await dbContext.Document.AddAsync(document);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                return BadRequest("No File Uploaded");
            }
            return Ok("File Uploaded...");*/
    }

    public class CompaneyImage
    {
        public int Id { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
