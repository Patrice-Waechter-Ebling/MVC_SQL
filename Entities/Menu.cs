using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class Menu
{
    public int Id { get; set; }

    public string NormalizedName { get; set; } = null!;

    public int SecureLevel { get; set; }
}
