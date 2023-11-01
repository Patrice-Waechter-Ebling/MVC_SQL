using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbDessin
{
    public int Id { get; set; }

    public string? NoProjet { get; set; }

    public string? NoDessin { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }
}
