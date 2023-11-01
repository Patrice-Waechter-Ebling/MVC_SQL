using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetUserslogin
{
    public int Id { get; set; }

    public string Loginprovider { get; set; } = null!;

    public string Providerkey { get; set; } = null!;

    public string? Providerdisplayname { get; set; }

    public int Userid { get; set; }

    public virtual AspNetUser IdNavigation { get; set; } = null!;
}
