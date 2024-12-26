using System;
using System.Collections.Generic;

namespace PrintInfoDB_COPY.Models;

public partial class Product
{
    public int Id { get; set; }

    public int IdTypeOfProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinCostForPartner { get; set; }

    public virtual TypesOfProduct IdTypeOfProductNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
