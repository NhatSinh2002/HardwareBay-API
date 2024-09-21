using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.Domain
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        public string Description { get; set; }

        [MaxLength(255)]
        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
