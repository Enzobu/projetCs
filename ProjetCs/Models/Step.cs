using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class Step
{
    public int IdStep { get; set; }

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public string Name { get; set; } = null!;
}
