using System;
using System.Collections.Generic;

namespace Freelance.Domain.Entities;

public partial class Messagerie
{
    public int Id { get; set; }

    public int? ExpediteurId { get; set; }

    public int? DestinataireId { get; set; }

    public string? Msg { get; set; }

    public DateTime? DateMsg { get; set; }

    public virtual Condidat? Expediteur { get; set; }

    public virtual Entreprise? ExpediteurNavigation { get; set; }
}
