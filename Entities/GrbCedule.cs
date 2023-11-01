using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbCedule
{
    public int Id { get; set; }

    public string? Initiale { get; set; }

    public string? DateCedule { get; set; }

    public string? HeureDebut { get; set; }

    public string? HeureFin { get; set; }

    public string? Client { get; set; }

    public int? Joursemaine { get; set; }

    public string? Transport { get; set; }

    public int? Finprojet { get; set; }

    public bool? Alarme { get; set; }
}
