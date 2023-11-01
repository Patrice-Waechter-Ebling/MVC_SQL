using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbSortieMateriel
{
    public int Id { get; set; }

    public string? Qte { get; set; }

    public string? Nom { get; set; }

    public string? NoProjet { get; set; }

    public string? NoItem { get; set; }

    public string? Date { get; set; }

    public string? Type { get; set; }
}
