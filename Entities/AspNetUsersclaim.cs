using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetUsersclaim
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public string? Claimtype { get; set; }

    public string? Claimvalue { get; set; }

    public virtual AspNetRole IdNavigation { get; set; } = null!;
}
