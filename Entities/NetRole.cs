using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class NetRole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<NetUser> NetUsers { get; set; } = new List<NetUser>();
}
