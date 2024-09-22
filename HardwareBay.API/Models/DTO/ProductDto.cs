using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HardwareBay.API.Models.DTO
{
    public class ProductDto
    {
        public Guid ProductID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        [Required]
        public Guid CategoryID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        public string? Description { get; set; }

        [MaxLength(255)]
        public string? ImageUrl { get; set; }
    }
}
