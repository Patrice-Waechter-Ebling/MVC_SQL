using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class ContactPermaRoute
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Courriel { get; set; } = null!;

    public string Poste { get; set; } = null!;

    public string Cellulaire { get; set; } = null!;
}
