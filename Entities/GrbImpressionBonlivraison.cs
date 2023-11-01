using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbImpressionBonlivraison
{
    public int Id { get; set; }

    public string? QteCom { get; set; }

    public string? QteLivr { get; set; }

    public string? QteBo { get; set; }

    public string? Description { get; set; }

    public string? Manufacturier { get; set; }

    public string? User { get; set; }
}
