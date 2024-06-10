using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class Registredboat
{
    public int IdRegisteredBoat { get; set; }

    public bool InRace { get; set; }

    public int RaceTime { get; set; }

    public int RealTime { get; set; }

    public int IdBoat { get; set; }
}
