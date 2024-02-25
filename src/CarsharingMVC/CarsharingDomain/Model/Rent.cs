using System;
using System.Collections.Generic;

namespace CarsharingDomain.Model;

public partial class Rent : Entity
{

    public int CustId { get; set; }

    public int CarId { get; set; }

    public int Cszid { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly FinishDate { get; set; }

    public double CostPerDay { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual CarSharingZone Csz { get; set; } = null!;

    public virtual Customer Cust { get; set; } = null!;
}
