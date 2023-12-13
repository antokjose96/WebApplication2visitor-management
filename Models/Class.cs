using System.ComponentModel.DataAnnotations;

namespace WebApplication2visitor_management.Models
{
    public class Class
    {
        [Key] // This annotation specifies that the Id property is the primary key
        public int VisitorId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone_Number { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
