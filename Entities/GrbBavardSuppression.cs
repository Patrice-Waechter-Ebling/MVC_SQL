using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbBavardSuppression
{
    public int Id { get; set; }

    public int? Iduser { get; set; }

    public string? NoProjSoum { get; set; }

    public string? Type { get; set; }

    public string? Qte { get; set; }

    public string? NoItem { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }
}
