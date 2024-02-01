﻿using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class DomaineExpertise
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public virtual ICollection<ComptenceDmExpertise> ComptenceDmExpertises { get; set; } = new List<ComptenceDmExpertise>();
}
