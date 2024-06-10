using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class Penalty
{
    public int IdPenalty { get; set; }

    public int Duration { get; set; }

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;
}
