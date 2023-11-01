using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbImpressionSommairePunchGrb
{
    public int Id { get; set; }

    public string? Employe { get; set; }

    public string? NoProjet { get; set; }

    public string? Date { get; set; }

    public string? Commentaire { get; set; }

    public string? HeureDebut { get; set; }

    public string? HeureFin { get; set; }

    public string? NbreKm { get; set; }

    public string? Total { get; set; }
}
