using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ENTITIES;

public partial class Order: INotifyPropertyChanged, ICloneable
{
    public int Id { get; set; }

    public string MaDonHang { get; set; } = null!;

    public int SanPham { get; set; }

    public DateTime NgayDonHang { get; set; }

    public int SoLuong { get; set; }

    public string? ChiTiet { get; set; }

    public int TriGia { get; set; }

    public virtual Product SanPhamNavigation { get; set; } = null!;
    public object Clone()
    {
        return MemberwiseClone();
    }
    public event PropertyChangedEventHandler? PropertyChanged;
}
