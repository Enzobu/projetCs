using System;
using System.Collections.Generic;

namespace ProjetCs.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Mail { get; set; } = null!;
}
