using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Formation
{
    public int Id { get; set; }

    public string? Niveau { get; set; }

    public string? Ecole { get; set; }

    public string? Description { get; set; }

    public int? IdVille { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Condidat? IdCondidatNavigation { get; set; }

    public virtual Ville? IdVilleNavigation { get; set; }
}
