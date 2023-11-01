using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbCatalogueMec
{
    public int Id { get; set; }

    public string? PieceGrb { get; set; }

    public string? Piece { get; set; }

    public string? PieceModif { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public string? Fabricant { get; set; }

    public string? Commentaire { get; set; }

    public string? Categorie { get; set; }
}
