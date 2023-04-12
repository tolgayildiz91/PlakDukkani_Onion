using Microsoft.EntityFrameworkCore;
using PlakDukkani_Onion.Domain.Entities;
using PlakDukkani_Onion.Domain.Entities.Abstract;
using PlakDukkani_Onion.Infastructure.EntityMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Infastructure.DataAccess
{
    public class PlakDukkaniDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=PlakDukkanimDB;uid=sa;pwd=123;trustservercertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {
            var entity = ChangeTracker.Entries<IBaseEntity>();
            foreach (var item in entity)
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.CreatedDate = DateTime.Now;
                    item.Entity.CreatedBy = "Admin";
                    item.Entity.Status = Domain.Enums.Status.Active;
                }
                else if (item.State == EntityState.Modified || item.State == EntityState.Deleted)
                {

                    item.Entity.ModifiedDate = DateTime.Now;
                    item.Entity.ModifiedBy = "Admin";

                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }



    }
}
