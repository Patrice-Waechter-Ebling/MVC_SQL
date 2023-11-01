using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbInventaireElec
{
    public int Id { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }

    public string? Manufacturier { get; set; }

    public string? QteBoite { get; set; }

    public string? PrixListe { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public string? Commentaires { get; set; }

    public string? Localisation { get; set; }

    public string? DeviseMonetaire { get; set; }

    public string? QuantiteStock { get; set; }

    public string? QuantiteCommandee { get; set; }

    public bool? Minimum { get; set; }

    public string? QuantiteMinimum { get; set; }

    public string? Commande { get; set; }

    public string? NoProjet { get; set; }

    public bool? CommandeParBoite { get; set; }
}
