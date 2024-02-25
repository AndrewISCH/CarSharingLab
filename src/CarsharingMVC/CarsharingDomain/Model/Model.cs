using System;
using System.Collections.Generic;

namespace CarsharingDomain.Model;

public partial class Model : Entity
{

    public string? ModelName { get; set; }

    public int NumOfSeats { get; set; }

    public bool IsAutomatic { get; set; }

    public double EngineVolume { get; set; }

    public bool HasCooling { get; set; }

    public string Brand { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
