using LockTheVote.DataAccess.DBEntity;
using Microsoft.EntityFrameworkCore;

namespace LockTheVote.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        //DbSets
        public DbSet<UserMaster> Users { get; set; }
        public DbSet<RoleMaster> Roles { get; set; }
        public DbSet<RegionMaster> Regions { get; set; }
        public DbSet<ElectionMaster> Elections { get; set; }
        public DbSet<ConfigurationMaster> Configurations { get; set; }
        public DbSet<VoteMaster> Votes { get; set; }
        public DbSet<VoteMasterHistory> VoteHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
