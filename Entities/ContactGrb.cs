using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class ContactGrb
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Courriel { get; set; } = null!;

    public int? Poste { get; set; }

    public string Celluraire { get; set; } = null!;
}
