using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class GrbContactClient
{
    public int Id { get; set; }

    public int? Noclient { get; set; }

    public int? Nocontact { get; set; }
}
