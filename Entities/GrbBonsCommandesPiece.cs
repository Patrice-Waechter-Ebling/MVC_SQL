using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbBonsCommandesPiece
{
    public int Id { get; set; }

    public string? NoBonCommande { get; set; }

    public int? NoFournisseur { get; set; }

    public string? Qte { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }

    public string? Manufact { get; set; }

    public string? Prix { get; set; }

    public string? Escompte { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? NumeroLigne { get; set; }
}
