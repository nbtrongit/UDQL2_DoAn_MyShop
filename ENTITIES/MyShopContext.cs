using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ENTITIES;

public partial class MyShopContext : DbContext
{
    public MyShopContext()
    {
    }

    public MyShopContext(DbContextOptions<MyShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-922J4KT; User Id=sa;Password=123456; Initial Catalog=MyShop; TrustServerCertificate=True");*/
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = File.ReadAllText("Config.txt");
        optionsBuilder.UseSqlServer(connection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Loai");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NgayDonHang).HasColumnType("date");
            entity.Property(e => e.TriGia)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.SanPhamNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SanPham");

            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.LoaiSanPhamNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.LoaiSanPham)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_SanPham_Loai");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TaiKhoan");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
