using System;
using System.Collections.Generic;

namespace CarsharingDomain.Model;

public partial class Customer : Entity
{

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int NumOfOrders { get; set; }

    public virtual ICollection<Rent> Rents { get; set; } = new List<Rent>();
}
