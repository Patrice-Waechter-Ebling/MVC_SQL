using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbImpressionPoste
{
    public int Id { get; set; }

    public string? Attention { get; set; }

    public string? Client { get; set; }

    public string? AdresseLiv { get; set; }

    public string? VilleProv { get; set; }

    public string? PaysCode { get; set; }
}
