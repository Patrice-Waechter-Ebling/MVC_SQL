using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbPunch
{
    public int Id { get; set; }

    public int? NoEmploye { get; set; }

    public string? NoProjet { get; set; }

    public string? Date { get; set; }

    public bool? ModifDebut { get; set; }

    public string? HeureDebut { get; set; }

    public bool? ModifFin { get; set; }

    public string? HeureFin { get; set; }

    public string? Commentaire { get; set; }

    public bool? Facture { get; set; }

    public string? NoFacture { get; set; }

    public string? NoClient { get; set; }

    public bool? Km { get; set; }

    public string? NbreKm { get; set; }

    public string? Type { get; set; }
}
