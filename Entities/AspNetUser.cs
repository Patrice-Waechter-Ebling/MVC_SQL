﻿using System;
using System.Collections.Generic;

namespace MVC_SQL.Entities;

public partial class AspNetUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Normalizedusername { get; set; }

    public string? Email { get; set; }

    public string? Normalizedemail { get; set; }

    public bool Emailconfirmed { get; set; }

    public string? Passwordhash { get; set; }

    public string? Securitystamp { get; set; }

    public string? Concurrencystamp { get; set; }

    public string? Phonenumber { get; set; }

    public bool Phonenumberconfirmed { get; set; }

    public bool Twofactorenabled { get; set; }

    public DateTime? Lockoutend { get; set; }

    public bool Lockoutenabled { get; set; }

    public int Accessfailedcount { get; set; }

    public byte[] Salt { get; set; } = null!;

    public virtual AspNetUserslogin? AspNetUserslogin { get; set; }

    public virtual AspNetUsersrole? AspNetUsersrole { get; set; }

    public virtual AspNetUserstoken? AspNetUserstoken { get; set; }
}
