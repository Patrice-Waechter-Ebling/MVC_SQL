﻿using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbOutil
{
    public int Id { get; set; }

    public string? NoOutils { get; set; }

    public string? NomOutils { get; set; }

    public string? Departement { get; set; }

    public string? Cout { get; set; }

    public string? TypeEtiquette { get; set; }

    public string? DateAchat { get; set; }

    public string? DateHorsFonction { get; set; }

    public string? Commentaire { get; set; }
}
