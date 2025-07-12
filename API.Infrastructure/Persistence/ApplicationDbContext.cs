using API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Palestra> Palestras { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Palestra>(p =>
            {
                p.HasKey(p => p.Id);

                p.HasMany(p => p.Participantes)
                    .WithOne(p => p.Palestra)
                    .HasForeignKey(p => p.PalestraId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Participante>(p =>
            {
                p.HasKey(p => p.Id);

                p.HasOne(p => p.Palestra)
                    .WithMany(p => p.Participantes)
                    .HasForeignKey(p => p.PalestraId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
