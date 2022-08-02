using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalServiceCenter.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [Column (TypeName ="varchar(255)")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName ="char(50)")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}
