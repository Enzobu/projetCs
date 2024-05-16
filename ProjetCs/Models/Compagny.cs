using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class Compagny
{
    public int IdCompagny { get; set; }

    public string? Iban { get; set; }

    public string Name { get; set; } = null!;
}
