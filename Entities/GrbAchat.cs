using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbAchat
{
    public int Id { get; set; }

    public string? Idachat { get; set; }

    public int? IndexAchat { get; set; }

    public string? Raison { get; set; }

    public string? DateAchat { get; set; }

    public int? Acheteur { get; set; }

    public string? PrixTotal { get; set; }

    public string? Type { get; set; }

    public bool? Modification { get; set; }

    public string? Par { get; set; }
}
