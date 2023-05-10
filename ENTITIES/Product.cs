using System;
using System.Collections.Generic;

namespace ENTITIES;

public partial class Product
{
    public int Id { get; set; }

    public string? Ten { get; set; }

    public int? Gia { get; set; }

    public string? MoTa { get; set; }

    public string? HinhAnh { get; set; }

    public int? LoaiSanPham { get; set; }

    public string? SanXuat { get; set; }

    public int SoLuong { get; set; }

    public virtual Category? LoaiSanPhamNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
