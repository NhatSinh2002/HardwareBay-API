using HardwareBay.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HardwareBay.API.Data
{
    public class HardwareBayDbContext:DbContext
    {
        public HardwareBayDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { 

        }

        // Khai báo các DbSet tương ứng với các bảng
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }


        //// Phương thức OnModelCreating để thiết lập cấu hình bổ sung cho các quan hệ và ràng buộc
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Thiết lập quan hệ 1-n giữa Order và OrderDetail
        //    modelBuilder.Entity<Order>()
        //        .HasMany(o => o.OrderDetails)
        //        .WithOne(od => od.Order)
        //        .HasForeignKey(od => od.OrderID)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Thiết lập quan hệ 1-n giữa Product và Review
        //    modelBuilder.Entity<Product>()
        //        .HasMany(p => p.Reviews)
        //        .WithOne(r => r.Product)
        //        .HasForeignKey(r => r.ProductID)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Thiết lập quan hệ 1-n giữa User và Order
        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Orders)
        //        .WithOne(o => o.User)
        //        .HasForeignKey(o => o.UserID)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // Tùy chỉnh bổ sung nếu cần...
        //}
    }
}
