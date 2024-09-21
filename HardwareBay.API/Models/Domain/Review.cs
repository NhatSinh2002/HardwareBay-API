using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class Review
    {
        [Key]
        public Guid ReviewID { get; set; } = Guid.NewGuid();

        [ForeignKey("Product")]
        public Guid ProductID { get; set; }

        [ForeignKey("User")]
        public Guid UserID { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
