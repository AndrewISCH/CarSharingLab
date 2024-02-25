using System;
using System.Collections.Generic;

namespace CarsharingDomain.Model;

public partial class CarSharingZone : Entity
{

    public string Town { get; set; } = null!;

    public int CarCapacity { get; set; }

    public decimal? Longtitude { get; set; }

    public decimal? Latitude { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Rent> Rents { get; set; } = new List<Rent>();
}
