using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class Registredboat
{
    public int IdBoat { get; set; }

    public bool InRace { get; set; }

    public int RaceTime { get; set; }

    public int RealTime { get; set; }
}
