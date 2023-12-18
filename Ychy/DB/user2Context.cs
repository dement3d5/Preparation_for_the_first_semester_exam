using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ychy.Models;

namespace Ychy.DB
{
    public partial class user2Context : DbContext
    {
        public user2Context()
        {
        }
        static user2Context instance;
        public static user2Context GetInstance()
        {
            if (instance == null)
                instance = new user2Context();
            return instance;
        }


        public user2Context(DbContextOptions<user2Context> options)
            : base(options)
        {
        }


        public virtual DbSet<Auth> Auths { get; set; } = null!;
        public virtual DbSet<Nteam> Nteams { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LOCKSMITH; database=user2; user=user2; password=user2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>(entity =>
            {
                entity.ToTable("Auth");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Nteam>(entity =>
            {
                entity.ToTable("NTeam");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NteamId).HasColumnName("NTeamId");

                entity.Property(e => e.Sname)
                    .HasMaxLength(10)
                    .HasColumnName("SName")
                    .IsFixedLength();

                entity.HasOne(d => d.Nteam)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.NteamId)
                    .HasConstraintName("FK_Team_NTeam");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
