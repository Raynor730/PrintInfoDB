using System;
using System.Collections.Generic;

namespace PrintInfoDB_COPY;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypeOfPartner { get; set; }

    public string NamePartner { get; set; } = null!;

    public string LegalAddres { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string DirectorFullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Rating { get; set; }

    public virtual TypesOfPartner IdTypeOfPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
