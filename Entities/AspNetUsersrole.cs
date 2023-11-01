using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetUsersrole
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public int Roleid { get; set; }

    public virtual AspNetUser Id1 { get; set; } = null!;

    public virtual AspNetRole IdNavigation { get; set; } = null!;
}
