using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class ModeTravail
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public virtual ICollection<Offre> Offres { get; set; } = new List<Offre>();
}
