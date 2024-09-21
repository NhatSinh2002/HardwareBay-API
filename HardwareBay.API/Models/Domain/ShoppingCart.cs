using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class ShoppingCart
    {
        [Key]
        public Guid CartID { get; set; } = Guid.NewGuid();

        [ForeignKey("User")]
        public Guid UserID { get; set; }

        [ForeignKey("Product")]
        public Guid ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
