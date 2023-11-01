using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class Outlook
{
    public int Id { get; set; }

    public string? NomContact { get; set; }

    public string? Compagnie { get; set; }

    public string? Telephonne { get; set; }

    public string? Cellulaire { get; set; }

    public string? EMail { get; set; }

    public string? EntryIdoutlook { get; set; }

    public string? Noposte { get; set; }
}
