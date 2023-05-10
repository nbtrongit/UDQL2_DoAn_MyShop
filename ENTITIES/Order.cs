using System;
using System.Collections.Generic;

namespace ENTITIES;

public partial class Order
{
    public int Id { get; set; }

    public string MaDonHang { get; set; } = null!;

    public int SanPham { get; set; }

    public DateTime NgayDonHang { get; set; }

    public int SoLuong { get; set; }

    public string? ChiTiet { get; set; }

    public string? TriGia { get; set; }

    public virtual Product SanPhamNavigation { get; set; } = null!;
}
