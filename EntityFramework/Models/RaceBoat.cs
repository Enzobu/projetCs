using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class RaceBoat
{
    public int IdBoat { get; set; }

    public int IdRace { get; set; }

    public bool IsRunning { get; set; }
}
