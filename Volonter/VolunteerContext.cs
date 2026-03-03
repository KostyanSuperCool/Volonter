using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Volonter;

public partial class VolunteerContext : DbContext
{
    public VolunteerContext()
    {
    }

    public VolunteerContext(DbContextOptions<VolunteerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventsName> EventsNames { get; set; }

    public virtual DbSet<RegistersVolonter> RegistersVolonters { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusesEvent> StatusesEvents { get; set; }

    public virtual DbSet<StatusesRegister> StatusesRegisters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Volunteer;Username = postgres;Password = 1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountVolonter).HasColumnName("count_volonter");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdCategories).HasColumnName("id_categories");
            entity.Property(e => e.IdStatusEvents).HasColumnName("id_status_events");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NameEvents).HasColumnName("name_events");
            entity.Property(e => e.Place).HasColumnName("place");

            entity.HasOne(d => d.IdCategoriesNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("events_id_categories_fkey");

            entity.HasOne(d => d.IdStatusEventsNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdStatusEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("events_id_status_events_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("events_id_user_fkey");
        });

        modelBuilder.Entity<EventsName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_name_pkey");

            entity.ToTable("events_name");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Event).HasColumnName("event");
        });

        modelBuilder.Entity<RegistersVolonter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("registers_volonter_pkey");

            entity.ToTable("registers_volonter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRegister).HasColumnName("date_register");
            entity.Property(e => e.IdEvents).HasColumnName("id_events");
            entity.Property(e => e.IdStatusRegister).HasColumnName("id_status_register");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdEventsNavigation).WithMany(p => p.RegistersVolonters)
                .HasForeignKey(d => d.IdEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("registers_volonter_id_events_fkey");

            entity.HasOne(d => d.IdStatusRegisterNavigation).WithMany(p => p.RegistersVolonters)
                .HasForeignKey(d => d.IdStatusRegister)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("registers_volonter_id_status_register_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.RegistersVolonters)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("registers_volonter_id_user_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Role1).HasColumnName("role");
        });

        modelBuilder.Entity<StatusesEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_events_pkey");

            entity.ToTable("statuses_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusEvent).HasColumnName("status_event");
        });

        modelBuilder.Entity<StatusesRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_register_pkey");

            entity.ToTable("statuses_register");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
