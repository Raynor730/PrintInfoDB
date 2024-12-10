using System;
using System.Collections.Generic;

namespace PrintInfoDB_COPY;

public partial class TypesOfProduct
{
    public int Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
