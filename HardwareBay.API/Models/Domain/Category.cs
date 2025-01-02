using System.ComponentModel.DataAnnotations;

namespace HardwareBayAPI.Models.Domain
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
