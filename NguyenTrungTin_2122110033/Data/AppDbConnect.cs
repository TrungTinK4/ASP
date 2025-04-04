using Microsoft.EntityFrameworkCore;
using NguyenTrungTin_2122110033.Model;

namespace NguyenTrungTin_2122110033.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình quan hệ: Order - OrderDetails (1 - nhiều)
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            // Cấu hình quan hệ: OrderDetail - Product (1 - 1)
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany() // Nếu trong Product chưa có List<OrderDetail>
                .HasForeignKey(od => od.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
