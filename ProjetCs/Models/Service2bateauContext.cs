using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetCs.Models;

public partial class Service2bateauContext : DbContext
{
    public Service2bateauContext()
    {
    }

    public Service2bateauContext(DbContextOptions<Service2bateauContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Server=localhost;Database=service2bateau;Uid=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
