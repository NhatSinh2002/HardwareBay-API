using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailID { get; set; } = Guid.NewGuid();

        [ForeignKey("Order")]
        public Guid OrderID { get; set; }

        [ForeignKey("Product")]
        public Guid ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
