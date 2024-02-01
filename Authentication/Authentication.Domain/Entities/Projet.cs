using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Projet
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Condidat? IdCondidatNavigation { get; set; }
}
