using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbTempInventaire
{
    public int Id { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }
}
