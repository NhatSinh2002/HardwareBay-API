using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; } = Guid.NewGuid();

        [ForeignKey("User")]
        public Guid UserID { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } = "Pending";

        // Navigation Properties
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Payment Payment { get; set; }
    }
}
