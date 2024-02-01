using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Ville
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Condidat> Condidats { get; set; } = new List<Condidat>();

    public virtual ICollection<Entreprise> Entreprises { get; set; } = new List<Entreprise>();

    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    public virtual ICollection<Formation> Formations { get; set; } = new List<Formation>();

    public virtual ICollection<Offre> Offres { get; set; } = new List<Offre>();
}
