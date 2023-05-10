using System;
using System.Collections.Generic;

namespace ENTITIES;

public partial class Category
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
