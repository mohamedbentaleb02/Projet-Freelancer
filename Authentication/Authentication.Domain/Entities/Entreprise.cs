using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Entreprise
{
    public int Id { get; set; }

    public string? RaisonSociale { get; set; }

    public string? Logo { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? Adresse { get; set; }

    public int? IdVille { get; set; }

    public virtual ICollection<ConsultaionProfil> ConsultaionProfils { get; set; } = new List<ConsultaionProfil>();

    public virtual Ville? IdVilleNavigation { get; set; }

    public virtual ICollection<Messagerie> Messageries { get; set; } = new List<Messagerie>();
}
