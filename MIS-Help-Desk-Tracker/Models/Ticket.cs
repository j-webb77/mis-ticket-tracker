using System.ComponentModel.DataAnnotations;

namespace MisHelpDeskTracker.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Open";

        [Required]
        [StringLength(20)]
        public string Priority { get; set; } = "Medium";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? AssignedTo { get; set; }
    }
}
