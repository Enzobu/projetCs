using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class BoatParticipant
{
    public int IdBoat { get; set; }

    public int IdUser { get; set; }
}
