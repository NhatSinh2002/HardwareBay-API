using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; } = Guid.NewGuid();

        [ForeignKey("Order")]
        public Guid OrderID { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        // Navigation Property
        public Order Order { get; set; }
    }
}
