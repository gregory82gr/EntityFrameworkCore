using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Data.Configurations;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext:DbContext
    {
        
        public FootballLeageDbContext(DbContextOptions<FootballLeageDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<TeamsAndLeaguesView> TeamsAndLeaguesView { get; set; }

        //public string DbPath { get; private set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<TeamsAndLeaguesView>().HasNoKey().ToView("vw_TeamsAndLeagues");
        }
    }
}
