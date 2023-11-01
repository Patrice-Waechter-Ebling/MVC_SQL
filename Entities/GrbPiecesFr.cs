﻿using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbPiecesFr
{
    public int Id { get; set; }

    public int? Idfrs { get; set; }

    public string? Piece { get; set; }

    public string? TableElec { get; set; }

    public string? PrixSp { get; set; }

    public string? PersRess { get; set; }

    public string? PrixList { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public string? Date { get; set; }

    public string? EntrerPar { get; set; }

    public string? Valide { get; set; }

    public bool? Quoter { get; set; }

    public string? DeviseMonetaire { get; set; }

    public string? PrixReel { get; set; }

    public string? Type { get; set; }
}
