using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbFournisseur
{
    public int Id { get; set; }

    public int Idfrs { get; set; }

    public string? NomFournisseur { get; set; }

    public string? Abbreviation { get; set; }

    public string? Rep { get; set; }

    public string? Interne { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }

    public string? ProvEtat { get; set; }

    public string? Pays { get; set; }

    public string? CodePostal { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? CondTransport { get; set; }

    public string? Noposte { get; set; }

    public string? Siteweb { get; set; }

    public string? Commentaire { get; set; }

    public string? DateCreation { get; set; }

    public string? UserCreation { get; set; }

    public string? DateModification { get; set; }

    public string? UserModification { get; set; }

    public string? EntryIdoutlook { get; set; }

    public bool? Supprime { get; set; }

    public string? Categorie { get; set; }
}
