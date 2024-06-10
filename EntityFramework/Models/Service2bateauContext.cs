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

    public virtual DbSet<Boat> Boats { get; set; }

    public virtual DbSet<BoatParticipant> BoatParticipants { get; set; }

    public virtual DbSet<BoatPenalty> BoatPenalties { get; set; }

    public virtual DbSet<Compagny> Compagnies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EtapeCourse> EtapeCourses { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Penalty> Penalties { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<RaceBoat> RaceBoats { get; set; }

    public virtual DbSet<Registredboat> Registredboats { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StapPenalty> StapPenalties { get; set; }

    public virtual DbSet<Step> Steps { get; set; }

    public virtual DbSet<Stepraceregisteredboat> Stepraceregisteredboats { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=service2bateau;Uid=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Boat>(entity =>
        {
            entity.HasKey(e => e.IdBoat).HasName("PRIMARY");

            entity.ToTable("boat");

            entity.HasIndex(e => e.IdCompagny, "id_compagny");

            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.IdCompagny).HasColumnName("id_compagny");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<BoatParticipant>(entity =>
        {
            entity.HasKey(e => new { e.IdBoat, e.IdUser }).HasName("PRIMARY");

            entity.ToTable("boat_participant");

            entity.HasIndex(e => e.IdUser, "id_user");

            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<BoatPenalty>(entity =>
        {
            entity.HasKey(e => new { e.IdBoat, e.IdPenalty }).HasName("PRIMARY");

            entity.ToTable("boat_penalty");

            entity.HasIndex(e => e.IdPenalty, "id_penalty");

            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.IdPenalty).HasColumnName("id_penalty");
        });

        modelBuilder.Entity<Compagny>(entity =>
        {
            entity.HasKey(e => e.IdCompagny).HasName("PRIMARY");

            entity.ToTable("compagny");

            entity.HasIndex(e => e.Iban, "IBAN").IsUnique();

            entity.Property(e => e.IdCompagny).HasColumnName("id_compagny");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .HasColumnName("IBAN");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<EtapeCourse>(entity =>
        {
            entity.HasKey(e => new { e.IdRace, e.IdStep }).HasName("PRIMARY");

            entity.ToTable("etape_course");

            entity.HasIndex(e => e.IdStep, "id_step");

            entity.Property(e => e.IdRace).HasColumnName("id_race");
            entity.Property(e => e.IdStep).HasColumnName("id_step");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("participant");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<Penalty>(entity =>
        {
            entity.HasKey(e => e.IdPenalty).HasName("PRIMARY");

            entity.ToTable("penalty");

            entity.Property(e => e.IdPenalty).HasColumnName("id_penalty");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .HasColumnName("longitude");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.IdRace).HasName("PRIMARY");

            entity.ToTable("race");

            entity.HasIndex(e => e.IdBoat, "id_boat");

            entity.Property(e => e.IdRace).HasColumnName("id_race");
            entity.Property(e => e.DateRace)
                .HasColumnType("date")
                .HasColumnName("dateRace");
            entity.Property(e => e.EndPointLongitude)
                .HasMaxLength(50)
                .HasColumnName("end_point_longitude");
            entity.Property(e => e.EndtPointLatitude)
                .HasMaxLength(50)
                .HasColumnName("endt_point_latitude");
            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.StartPointLatitude)
                .HasMaxLength(50)
                .HasColumnName("start_point_latitude");
            entity.Property(e => e.StartPointLongitude)
                .HasMaxLength(50)
                .HasColumnName("start_point_longitude");
        });

        modelBuilder.Entity<RaceBoat>(entity =>
        {
            entity.HasKey(e => new { e.IdBoat, e.IdRace }).HasName("PRIMARY");

            entity.ToTable("race_boat");

            entity.HasIndex(e => e.IdRace, "id_race");

            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.IdRace).HasColumnName("id_race");
            entity.Property(e => e.IsRunning).HasColumnName("isRunning");
        });

        modelBuilder.Entity<Registredboat>(entity =>
        {
            entity.HasKey(e => e.IdBoat).HasName("PRIMARY");

            entity.ToTable("registredboat");

            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.InRace).HasColumnName("inRace");
            entity.Property(e => e.RaceTime).HasColumnName("raceTime");
            entity.Property(e => e.RealTime).HasColumnName("realTime");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.HasIndex(e => e.IdUser, "id_user");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StapPenalty>(entity =>
        {
            entity.HasKey(e => new { e.IdPenalty, e.IdStep }).HasName("PRIMARY");

            entity.ToTable("stap_penalty");

            entity.HasIndex(e => e.IdStep, "id_step");

            entity.Property(e => e.IdPenalty).HasColumnName("id_penalty");
            entity.Property(e => e.IdStep).HasColumnName("id_step");
        });

        modelBuilder.Entity<Step>(entity =>
        {
            entity.HasKey(e => e.IdStep).HasName("PRIMARY");

            entity.ToTable("step");

            entity.Property(e => e.IdStep).HasColumnName("id_step");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Stepraceregisteredboat>(entity =>
        {
            entity.HasKey(e => e.IdStepRaceRegisteredBoat).HasName("PRIMARY");

            entity.ToTable("stepraceregisteredboat");

            entity.HasIndex(e => e.IdBoat, "id_boat");

            entity.HasIndex(e => e.IdPenalty, "id_penalty");

            entity.HasIndex(e => e.IdRace, "id_race");

            entity.HasIndex(e => e.IdStep, "id_step");

            entity.Property(e => e.IdStepRaceRegisteredBoat).HasColumnName("id_StepRaceRegisteredBoat");
            entity.Property(e => e.IdBoat).HasColumnName("id_boat");
            entity.Property(e => e.IdPenalty).HasColumnName("id_penalty");
            entity.Property(e => e.IdRace).HasColumnName("id_race");
            entity.Property(e => e.IdStep).HasColumnName("id_step");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("_user");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .HasColumnName("mail");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
