using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbDoublon
{
    public int Id { get; set; }

    public string? Piece { get; set; }

    public string? Fabricant { get; set; }

    public string? DescrFr { get; set; }

    public string? DescrEn { get; set; }

    public string? Categorie { get; set; }
}
