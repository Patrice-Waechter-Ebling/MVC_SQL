using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbErreur
{
    public int Id { get; set; }

    public string? Qui { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }

    public string? Form { get; set; }

    public string? Methode { get; set; }

    public int? NoLigne { get; set; }

    public int? NoErreur { get; set; }

    public string? Description { get; set; }

    public string? Source { get; set; }

    public string? Params { get; set; }
}
