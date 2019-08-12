using System.ComponentModel.DataAnnotations;

namespace FormSubmissionVal.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter a FirstName")]
        [MinLength(4)]
        [StringLength(50, ErrorMessage = "The first name must be at least 3 characters long")]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }
        
        [Required]
        [Range(0,150)]
        public int Age { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}