using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using MoscOwlAPI.Domain.Models;

namespace MoscOwlAPI.Data
{
    public class OwlDbContext : DbContext
    {
        public OwlDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<MemberTournament> MemberTournaments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                        .Property(p => p.Name)
                        .IsRequired();

            modelBuilder.Entity<Member>()
                        .Property(p => p.Surname)
                        .IsRequired();

            modelBuilder.Entity<MemberTournament>()
                        .HasKey(p => new { p.MemberId, p.TournamentId });

            modelBuilder.Entity<MemberTournament>()
                        .Property(p => p.Score)
                        .IsRequired();

            modelBuilder.Entity<MemberSeason>()
                        .HasNoKey()
                        .ToView("MemberSeasonView");

        }
    }
}
