using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbImpressionDemandePrixElec
{
    public int Id { get; set; }

    public string? Qte { get; set; }

    public string? NoPiece { get; set; }

    public string? Description { get; set; }

    public string? Manufacturier { get; set; }
}
