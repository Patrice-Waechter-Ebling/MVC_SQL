using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbContact
{
    public int Id { get; set; }

    public string? NomContact { get; set; }

    public string? Compagnie { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? Cellulaire { get; set; }

    public string? Pagette { get; set; }

    public string? Email { get; set; }

    public string? Noposte { get; set; }

    public string? Teldomicile { get; set; }

    public string? DateCreation { get; set; }

    public string? UserCreation { get; set; }

    public string? DateModification { get; set; }

    public string? UserModification { get; set; }

    public string? Commentaire { get; set; }

    public string? Titre { get; set; }

    public string? EntryIdoutlook { get; set; }

    public bool? Supprime { get; set; }
}
