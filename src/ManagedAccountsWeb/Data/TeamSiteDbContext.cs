using ManagedAccountClasses.TeamSite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagedAccountsWeb.Data.Migrations
{
    public class TeamSiteDbContext : DbContext
    {
        public TeamSiteDbContext(DbContextOptions<TeamSiteDbContext> options)
            : base(options)
        {
        }

        public DbSet<SpecialInstruction> SpecialInstructions { get; set; }
    }
}
