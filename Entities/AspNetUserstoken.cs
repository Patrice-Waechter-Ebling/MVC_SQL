using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetUserstoken
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public string Loginprovider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual AspNetUser IdNavigation { get; set; } = null!;
}
