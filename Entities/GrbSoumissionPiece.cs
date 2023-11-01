using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbSoumissionPiece
{
    public int Id { get; set; }

    public string? Idsoumission { get; set; }

    public int? Idsection { get; set; }

    public string? NumItem { get; set; }

    public string? Qte { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public string? Manufact { get; set; }

    public string? PrixList { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public int? Idfrs { get; set; }

    public string? Temps { get; set; }

    public string? TempsTotal { get; set; }

    public string? PrixTotal { get; set; }

    public string? ProfitArgent { get; set; }

    public string? SousSection { get; set; }

    public string? OrdreSection { get; set; }

    public int? NumeroLigne { get; set; }

    public string? PrixOrigine { get; set; }

    public string? Type { get; set; }

    public bool? Visible { get; set; }

    public bool? Commande { get; set; }

    public bool? Quote { get; set; }

    public bool? Recu { get; set; }

    public bool? Retour { get; set; }

    public bool? CommandeAnnulee { get; set; }

    public bool? PieceExtra { get; set; }

    public bool? MaterielInutile { get; set; }

    public string? Commentaire { get; set; }

    public bool? PieceExtraNonChargeable { get; set; }

    public bool? PieceExtraChargeable { get; set; }

    public string? LiaisonChargeable { get; set; }

    public string? Pid { get; set; }

    public string? Devise { get; set; }

    public bool? TransfertJob { get; set; }

    public string? Provenance { get; set; }
}
