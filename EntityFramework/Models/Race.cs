using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class Race
{
    public int IdRace { get; set; }

    public string? StartPointLongitude { get; set; }

    public string? StartPointLatitude { get; set; }

    public string? EndPointLongitude { get; set; }

    public string? EndtPointLatitude { get; set; }

    public DateTime DateRace { get; set; }

    public int IdRegisteredBoat { get; set; }
}
