using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbSoumProjSectionMec
{
    public int Id { get; set; }

    public string? NomSectionFr { get; set; }

    public string? NomSectionEn { get; set; }

    public int? Ordre { get; set; }
}
