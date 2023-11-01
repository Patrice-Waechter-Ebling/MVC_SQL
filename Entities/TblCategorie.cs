using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class TblCategorie
{
    public int Id { get; set; }

    public string? Correspondance { get; set; }

    public string? Nom { get; set; }
}
