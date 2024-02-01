using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Experience
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    public string? Local { get; set; }

    public string? Description { get; set; }

    public int? IdVille { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Condidat? IdCondidatNavigation { get; set; }

    public virtual Ville? IdVilleNavigation { get; set; }
}
