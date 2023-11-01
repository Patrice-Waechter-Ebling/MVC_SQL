using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbImpressionListePiece
{
    public int Id { get; set; }

    public string? Idsoumission { get; set; }

    public string? NomSection { get; set; }

    public string? SousSection { get; set; }

    public string? NumItem { get; set; }

    public string? Qte { get; set; }

    public string? Description { get; set; }

    public string? Manufact { get; set; }

    public string? Section { get; set; }

    public string? NomSousSection { get; set; }

    public string? Idsection { get; set; }

    public string? Pid { get; set; }
}
