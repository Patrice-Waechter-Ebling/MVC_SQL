using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbInventaireElecModif
{
    public int Id { get; set; }

    public string? Date { get; set; }

    public string? Idprojet { get; set; }

    public string? NoItem { get; set; }

    public string? Quantité { get; set; }

    public string? User { get; set; }
}
