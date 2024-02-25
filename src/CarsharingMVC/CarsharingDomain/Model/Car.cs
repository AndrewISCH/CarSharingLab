using System;
using System.Collections.Generic;

namespace CarsharingDomain.Model;

public partial class Car : Entity
{
    // 123
    public int ModelId { get; set; }

    public int Cszid { get; set; }

    public bool IsRented { get; set; }

    public DateOnly ProduceYear { get; set; }

    public DateOnly? TechInspirationDate { get; set; }

    public string Color { get; set; } = null!;

    public virtual CarSharingZone Csz { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;

    public virtual ICollection<Rent> Rents { get; set; } = new List<Rent>();
}
