using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbAlarme
{
    public int Id { get; set; }

    public string? Initiale { get; set; }

    public int? Idcedule { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }

    public string? Message { get; set; }

    public int? JourSemaine { get; set; }

    public int? NoEmploye { get; set; }

    public string? TypeCedule { get; set; }
}
