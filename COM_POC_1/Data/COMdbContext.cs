using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace COM_POC_1.Models
{
    public class CoMdbContext : DbContext
    {
        public CoMdbContext(DbContextOptions<CoMdbContext> options) : base(options)
        { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<BuildUp> BuildUps { get; set; }
        public DbSet<Rift> Rifts { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<PowerTag> PowerTags { get; set; }
        public DbSet<Crack> Cracks { get; set; }
        public DbSet<Fade> Fades { get; set; }
        public DbSet<Attention> Attentions { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Mc> Mcs { get; set; }
        public DbSet<StoryTag> StoryTags { get; set; }
        public DbSet<Status> Statuses { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theme>()
                .Property(t => t.RiftId)
                .IsRequired(false);

        }

    }
}
