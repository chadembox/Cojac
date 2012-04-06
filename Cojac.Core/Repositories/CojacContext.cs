using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public class CojacContext : DbContext
    {
        public DbSet<JUser> Users       { get; set; }
        public DbSet<NPGame> NPGames    { get; set; }
        public DbSet<NPTeam> NPTeams    { get; set; }
        public DbSet<NPSeries> NPSeries { get; set; }
        public DbSet<NPPick> NPPicks    { get; set; }
        public DbSet<NPRound> NPRounds  { get; set; }

        public CojacContext()
        {
            if (string.IsNullOrEmpty(Database.Connection.ConnectionString))
            {
                Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Cojac"].ConnectionString;
            }

            Database.SetInitializer<CojacContext>(new CojacContextInitializer());
        }

        public CojacContext(string connectionString) 
        {
            Database.Connection.ConnectionString = connectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            modelBuilder.Configurations.Add(new JUserMap());
            modelBuilder.Configurations.Add(new NPRoundMap());
            modelBuilder.Configurations.Add(new NPSeriesMap());
            modelBuilder.Configurations.Add(new NPGameMap());
            modelBuilder.Configurations.Add(new NPRoundMap());
            modelBuilder.Configurations.Add(new NPTeamMap());
            modelBuilder.Configurations.Add(new NPPickMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }

    public class JUserMap : EntityTypeConfiguration<JUser>
    {
        public JUserMap()
        {
            HasKey(j => j.Id);

            Property(j => j.Id).HasColumnName("UserID");
            Property(j => j.Username).HasColumnName("UserName");
            Property(j => j.IsActive).HasColumnName("ActiveFlag");
            Property(j => j.BirthdayDay).HasColumnName("BdayDay");
            Property(j => j.BirthdayMonth).HasColumnName("BdayMonth");
            Property(j => j.AnniversaryDay).HasColumnName("AnnvDay");
            Property(j => j.AnniversaryMonth).HasColumnName("AnnvDay");
        }
    }
    
    public class NPRoundMap : EntityTypeConfiguration<NPRound>
    {
        public NPRoundMap()
        {
            HasKey(r => r.RoundId);
            HasMany<NPSeries>(r => r.Series);                
        }
    }

    public class NPSeriesMap : EntityTypeConfiguration<NPSeries>
    {
        public NPSeriesMap()
        {
            HasKey(s => s.SeriesId);
            HasMany<NPGame>(s => s.Games);
            HasRequired<NPRound>(s => s.Round);
            HasRequired<NPTeam>(s => s.HigherSeed);
            HasRequired<NPTeam>(s => s.LowerSeed);
        }
    }

    public class NPGameMap : EntityTypeConfiguration<NPGame>
    {
        public NPGameMap()
        {
            HasKey(j => j.SeriesId);
            HasKey(j => j.Game);

            Property(j => j.SeriesId).HasColumnOrder(0);
            Property(j => j.Game).HasColumnOrder(1);
        }
    }

    public class NPTeamMap : EntityTypeConfiguration<NPTeam>
    {
        public NPTeamMap()
        {
            HasKey(t => t.TeamId);
        }
    }

    public class NPPickMap : EntityTypeConfiguration<NPPick>
    {
        public NPPickMap()
        {
            HasKey(p => p.PickId);

            HasRequired<NPSeries>(p => p.Series);
            HasRequired<NPTeam>(p => p.TeamPick);
        }
    }

    public class CojacContextInitializer : CreateDatabaseIfNotExists<CojacContext>
    {
        protected override void Seed(CojacContext context)
        {
            base.Seed(context);

            #region Add Teams

            //Add Teams
            context.NPTeams.Add(new NPTeam() { TeamId = "TE1", Name = "Chicago", Rank = 1 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE2", Name = "Miami", Rank = 2 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE3", Name = "Indiana", Rank = 3 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE4", Name = "Boston", Rank = 4 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE5", Name = "Atlanta", Rank = 5 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE6", Name = "Orlando", Rank = 6 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE7", Name = "Philadelphia", Rank = 7 });
            context.NPTeams.Add(new NPTeam() { TeamId = "TE8", Name = "New York", Rank = 8 });

            context.NPTeams.Add(new NPTeam() { TeamId = "WE1", Name = "Oklahoma City", Rank = 1 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE2", Name = "San Antonio", Rank = 2 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE3", Name = "L.A. Lakers", Rank = 3 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE4", Name = "L.A. Clippers", Rank = 4 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE5", Name = "Memphis", Rank = 5 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE6", Name = "Dallas", Rank = 6 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE7", Name = "Houston", Rank = 7 });
            context.NPTeams.Add(new NPTeam() { TeamId = "WE8", Name = "Denver", Rank = 8 });

            context.SaveChanges();

            #endregion

            #region Add Rounds

            //Add Rounds
            context.NPRounds.Add(new NPRound() { RoundId = "E1", Name = "Eastern Conference First Round" });
            context.NPRounds.Add(new NPRound() { RoundId = "W1", Name = "Western Conference First Round" });
            context.NPRounds.Add(new NPRound() { RoundId = "E2", Name = "Eastern Conference Semifinals" });
            context.NPRounds.Add(new NPRound() { RoundId = "W2", Name = "Western Conference Semifinals" });
            context.NPRounds.Add(new NPRound() { RoundId = "E3", Name = "Eastern Conference Finals" });
            context.NPRounds.Add(new NPRound() { RoundId = "W3", Name = "Western Conference Finals" });
            context.NPRounds.Add(new NPRound() { RoundId = "F",  Name = "NBA Championship" });
            
            context.SaveChanges();

            #endregion

            #region Add Series
            //Add First Set of Series...create screen to do the rest?
            var easternFirstRound = context.NPRounds.Find("E1");
            var westernFirstRound = context.NPRounds.Find("W1");

            for(int i = 1; i <= 4; i++)
            {                
                context.NPSeries.Add(new NPSeries()
                 {
                    Round = easternFirstRound,
                    HigherSeed = context.NPTeams.Find("TE" + i),
                    HigherSeedWinTotal = 0,
                    LowerSeed = context.NPTeams.Find("TE" + (9-i)),
                    LowerSeedWinTotal = 0
                 });

                         
                context.NPSeries.Add(new NPSeries()
                 {
                    Round = westernFirstRound,
                    HigherSeed = context.NPTeams.Find("TW" + i),
                    HigherSeedWinTotal = 0,
                    LowerSeed = context.NPTeams.Find("TW" + (9-i)),
                    LowerSeedWinTotal = 0
                 });
            }

            context.SaveChanges();

            #endregion

            #region Add Games

            for(int i = 1; i <= 7; i++)
            {                    
                foreach(var series in context.NPRounds.Find("E1").Series)
                {
                   series.Games.Add(new NPGame()
                    {
                        SeriesId = series.SeriesId,
                        Game = i,
                        DateTime = DateTime.Now.AddDays(i),
                        HigerSeedScore = 0,
                        LowerSeedScore = 0,
                        SeriesWon = false
                    });
                }

                foreach(var series in context.NPRounds.Find("W1").Series)
                {
                   series.Games.Add(new NPGame()
                    {
                        SeriesId = series.SeriesId,
                        Game = i,
                        DateTime = DateTime.Now.AddDays(i),
                        HigerSeedScore = 0,
                        LowerSeedScore = 0,
                        SeriesWon = false
                    });
                }
            }

            context.SaveChanges();
            #endregion

            #region Add Users

            //Just some basic info
            if (context.Users.Count() == 0)
            {
                context.Users.Add(new JUser()
                {
                    Id = 2,
                    Username = "Jeaux",
                    Password = "DA76734CA6E2F565815013C5009298D86F47EC9C",
                    Name = "Jeaux Smith",
                    Email = "im@jeaux.com"
                });

                context.Users.Add(new JUser()
                {
                    Id = 295,
                    Username = "mc2thaH",
                    Password = "69FD97D593FCB1C3B01ED0DB0A4FB344C0FA85C3",
                    Name = "Matt Chandler",
                    Email = "mkchandler@gmail.com"
                });

                context.Users.Add(new JUser()
                {
                    Id = 483,
                    Username = "vegashat",
                    Password = "DB2879E2D88BEB3A173B3389CCBA4263ED5C9396",
                    Name = "Chris Albrecht",
                    Email = "vegashat@hobbylobby.com"
                });

                context.Users.Add(new JUser()
                {
                    Id = 483,
                    Username = "Smokin Guns",
                    Password = "EB40A3120E0A26441E806BAFAECC963FB091A16C",
                    Name = "Bradley Lower",
                    Email = "bratleylower@gmail.com"
                });

                context.Users.Add(new JUser()
                {
                    Id = 483,
                    Username = "ChesterTheJester",
                    Password = "32A35EA4317AA076E31D3C483EA383D7C906BCA0",
                    Name = "Chad Hester",
                    Email = "chad.hester@hobbylobby.com"
                });
            }

            #endregion
        }
    }
}
