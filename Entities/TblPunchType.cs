using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class TblPunchType
{
    public int Id { get; set; }

    public string? Mode { get; set; }

    public string? Name { get; set; }
}
