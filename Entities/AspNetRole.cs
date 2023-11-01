using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetRole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Normalizedname { get; set; }

    public string? Concurrencystamp { get; set; }

    public virtual AspNetRoleclaim? AspNetRoleclaim { get; set; }

    public virtual AspNetUsersclaim? AspNetUsersclaim { get; set; }

    public virtual AspNetUsersrole? AspNetUsersrole { get; set; }
}
