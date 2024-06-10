using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string Name { get; set; } = null!;

    public int IdUser { get; set; }
}
