using Microsoft.EntityFrameworkCore;
using MoscOwlAPI.Domain.Models;

namespace MoscOwlAPI.Data
{
    public class OwlDbContext : DbContext
    {
        public OwlDbContext(DbContextOptions options) : base (options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<MemberTournament> MemberTournaments { get; set; }


    }
}
