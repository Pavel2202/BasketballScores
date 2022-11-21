namespace BasketballScoresAPI.Data
{
    using BasketballScoresAPI.Models;
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<MatchResult> MatchResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(x => x.Results)
                .WithOne(x => x.HomeTeam)
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
