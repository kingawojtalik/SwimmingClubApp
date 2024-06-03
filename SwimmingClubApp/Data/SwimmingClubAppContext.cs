using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Models;

namespace SwimmingClubApp.Data
{
    public class SwimmingClubAppContext : DbContext
    {
        public SwimmingClubAppContext (DbContextOptions<SwimmingClubAppContext> options)
            : base(options)
        {
        }

        public DbSet<SwimmingClubApp.Models.Swimmer> Swimmers { get; set; } = default!;
        public DbSet<SwimmingClubApp.Models.SwimmingGroup> SwimmingGroups { get; set; } = default!;
        public DbSet<SwimmingClubApp.Models.Training> Trainings { get; set; } = default!;
        public DbSet<SwimmingClubApp.Models.Competition> Competitions { get; set; } = default!;
        public DbSet<SwimmingClubApp.Models.Result> Results { get; set; } = default!;
    }
}
