using System.ComponentModel.DataAnnotations;

namespace WebApplication2visitor_management.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public DateTime Eventdate { get; set; }
    }
}
