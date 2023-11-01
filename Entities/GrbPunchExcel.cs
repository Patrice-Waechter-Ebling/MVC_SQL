using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbPunchExcel
{
    public int Id { get; set; }

    public int? NoEmploye { get; set; }

    public string? NoProjet { get; set; }

    public string? HeureDebut { get; set; }

    public string? HeureFin { get; set; }
}
