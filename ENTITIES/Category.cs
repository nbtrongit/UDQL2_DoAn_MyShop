using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ENTITIES;

public partial class Category : INotifyPropertyChanged, ICloneable
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public object Clone()
    {
        return MemberwiseClone();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
