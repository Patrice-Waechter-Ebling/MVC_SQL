using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbAutorisationPunch
{
    public int Id { get; set; }

    public int? NoEmploye { get; set; }

    public int? AutoriserPar { get; set; }
}
