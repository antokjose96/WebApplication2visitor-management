using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2visitor_management.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("Visitor")]
        public int VisitorId { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }

        public DateTime BookingDate { get; set; }
        // Add other properties as needed

        // Navigation property
        public Class Visitor { get; set; }
        public Event Event { get; set; }
    }
}
