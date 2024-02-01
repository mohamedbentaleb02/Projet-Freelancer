using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class ComptenceDmExpertise
{
    public int Id { get; set; }

    public int? IdCompetence { get; set; }

    public int? IdDmexpertise { get; set; }

    public virtual Competence? IdCompetenceNavigation { get; set; }

    public virtual DomaineExpertise? IdDmexpertiseNavigation { get; set; }
}
