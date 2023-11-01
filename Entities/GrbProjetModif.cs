using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbProjetModif
{
    public int Id { get; set; }

    public string? Idprojet { get; set; }

    public int? NoEmploye { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }

    public string? Type { get; set; }

    public string? TypeModif { get; set; }

    public string? Valeur { get; set; }
}
