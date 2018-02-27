using System.ComponentModel.DataAnnotations;

namespace Lab20.Models
{
    public class Register
    {
        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter A Valid First Name")]
        [Key]
        public string FirstName { get; set; }

        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter A Valid First Name")]
        [Key]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter A Valid Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(3)]
        public string Password { get; set; }


        public string Phone { get; set; }

        [Required]
        public bool EmailMe { get; set; }


    }

}
