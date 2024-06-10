using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class Boat
{
    public int IdBoat { get; set; }

    public string Name { get; set; } = null!;

    public int? IdCompagny { get; set; }
}
