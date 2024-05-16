using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class Stepraceregisteredboat
{
    public int IdStepRaceRegisteredBoat { get; set; }

    public int IdRace { get; set; }

    public int IdBoat { get; set; }

    public int IdStep { get; set; }

    public int IdPenalty { get; set; }
}
