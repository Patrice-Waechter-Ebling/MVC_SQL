﻿using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbClient
{
    public int Id { get; set; }

    public string? NomClient { get; set; }

    public string? Compagnie { get; set; }

    public string? Telephonne { get; set; }

    public string? Fax { get; set; }

    public string? Pagette { get; set; }

    public string? Cellulaire { get; set; }

    public string? ContactGrb { get; set; }

    public string? Email { get; set; }

    public string? AdresseLiv { get; set; }

    public string? VilleLiv { get; set; }

    public string? ProvEtatLiv { get; set; }

    public string? PaysLiv { get; set; }

    public string? CodePostalLiv { get; set; }

    public string? Noposte { get; set; }

    public string? Commentaire { get; set; }

    public string? SiteWeb { get; set; }

    public string? DateCreation { get; set; }

    public string? UserCreation { get; set; }

    public string? DateModification { get; set; }

    public string? UserModification { get; set; }

    public string? EntryIdoutlook { get; set; }

    public bool? Beton { get; set; }

    public bool? Pave { get; set; }

    public bool? Pharmaceutique { get; set; }

    public bool? Agroalimentaire { get; set; }

    public bool? Meuble { get; set; }

    public bool? Meunerie { get; set; }

    public bool? Manufacturier { get; set; }

    public bool? Autre { get; set; }

    public bool? Consultant { get; set; }

    public bool? Asphalte { get; set; }

    public bool? Icpi { get; set; }

    public bool? Potentiel { get; set; }

    public bool? ProduitsChimiques { get; set; }

    public bool? Supprime { get; set; }

    public string? NomContact { get; set; }
}
