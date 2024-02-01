using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Offre
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    public string? Descrpition { get; set; }

    public DateTime? Date { get; set; }

    public string? Dure { get; set; }

    public string? Adresse { get; set; }

    public int? IdVille { get; set; }

    public DateTime? DatePub { get; set; }

    public int? IdModetravail { get; set; }

    public virtual ICollection<CompetenceOffre> CompetenceOffres { get; set; } = new List<CompetenceOffre>();

    public virtual ModeTravail? IdModetravailNavigation { get; set; }

    public virtual Ville? IdVilleNavigation { get; set; }
}
