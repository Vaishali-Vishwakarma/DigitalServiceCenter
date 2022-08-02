using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalServiceCenter.Models
{
    public class Companey
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength=3)]
        [Column (TypeName ="varchar(50)")]
        [RegularExpression(@"^[A-Za-z]\w*$")]
        public string CompaneyName { get; set; }
        [Required]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string Discription { get; set; }

        [Required(ErrorMessage ="Address and Contact should be correct and Required")]
        [Column (TypeName = "varchar(200)")]
        [Display (Name =" Address/Contact")]
        public string AddressContactInfo { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }
}
