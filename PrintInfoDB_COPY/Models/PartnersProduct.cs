using System;
using System.Collections.Generic;

namespace PrintInfoDB_COPY.Models;

public partial class PartnersProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Quantity { get; set; }

    public DateOnly DateSell { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
