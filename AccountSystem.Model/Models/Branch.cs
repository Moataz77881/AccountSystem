using System;
using System.Collections.Generic;

namespace AccountSystem.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string BranchName { get; set; } = null!;

    public int CityId { get; set; }

    public virtual ICollection<Cashier> Cashiers { get; set; } = new List<Cashier>();

    public virtual City? City { get; set; }

}
