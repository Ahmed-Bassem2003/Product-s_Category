using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Final_Project.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " First Name Is Required")]
        [MinLength(3, ErrorMessage = "Name Min Length Is 3")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50")]
        [DisplayName("First Name")]
        [Column("First Name")] 
        public string FName { get; set; }

        [Required(ErrorMessage = "Last Name Is Required")]
        [MinLength(3, ErrorMessage = "Name Min Length Is 3")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50")]
        [DisplayName("Last Name")] 
        [Column("Last Name")] 
        public string LName { get; set; }

        [EmailAddress(ErrorMessage = "Please Enter A Valid Email")]
        [StringLength(100, ErrorMessage = "Email Must Be Between 4 and 100", MinimumLength = 4)]
        public string Email { get; set; }

        [MaxLength(30, ErrorMessage = "Password Max Length Is 30")]
        [MinLength(8, ErrorMessage = "Password Min Length Is 8")]
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
