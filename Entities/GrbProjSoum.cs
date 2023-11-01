using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbProjSoum
{
    public int Id { get; set; }

    public string? IdprojSoum { get; set; }

    public int? NoClient { get; set; }

    public string? DateOuverture { get; set; }

    public string? DateFermeture { get; set; }

    public string? RaisonFermeture { get; set; }

    public bool? Ouvert { get; set; }

    public bool? Verrouille { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }
}
