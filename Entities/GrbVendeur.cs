using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbVendeur
{
    public int Id { get; set; }

    public int? Idclient { get; set; }

    public string? Date { get; set; }

    public string? Contact { get; set; }

    public string? Commentaire { get; set; }

    public string? EnregPar { get; set; }

    public string? Etat { get; set; }

    public string? Enregistrerpar { get; set; }

    public string? Type { get; set; }
}
